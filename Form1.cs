using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace EvaluarTags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           ListaTagsConcentrado.Rows.Clear();
            listaTags.Clear();
            dgvFuncionando.Rows.Clear();
            dgvNoReportan.Rows.Clear();
            dgvNoSirven.Rows.Clear();
        }

        /// <summary>
        /// Evento que obtiene la tecla precionada para el amnejo de los registros del concentrado de tags
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListaTagsConcentrado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject d = ListaTagsConcentrado.GetClipboardContent();
                Clipboard.SetDataObject(d);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int row = ListaTagsConcentrado.CurrentCell.RowIndex;
                int col = ListaTagsConcentrado.CurrentCell.ColumnIndex;
                foreach (string line in lines)
                {
                    if (row < ListaTagsConcentrado.RowCount && line.Length > 0)
                    {
                        string[] cells = line.Split('\t');
                        for (int i = 0; i < cells.GetLength(0); ++i)
                        {
                            if (col + i < this.ListaTagsConcentrado.ColumnCount)
                        {
                            ListaTagsConcentrado.Rows.Insert(ListaTagsConcentrado.CurrentRow.Index, 1);

                            ListaTagsConcentrado[col + i, row].Value = Convert.ChangeType(cells[i], ListaTagsConcentrado[col + i, row].ValueType);
                        }
                            else
                            {
                                break;
                            }
                        }
                        row++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        List<string> listaTags = new List<string>();

        /// <summary>
        /// Evento click del botonEvaluar tags
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (ListaTagsConcentrado.RowCount > 0)
            {

                    foreach (DataGridViewRow row in ListaTagsConcentrado.Rows)
                {
                    if (row.Cells["ListaTags"].Value != null && row.Cells["ListaTags"].Value.ToString().Trim() != "")
                    {
                        string imei = row.Cells[0].Value.ToString().Trim();
                        listaTags.Add(imei.Substring(0,15));
                    }
                }
                listaTags =new List<string>(listaTags.Distinct());

                    Tuple<List<string>, List<string>, List<string>> ListasTagsEvaluados;


          
                    ListasTagsEvaluados = EvaluarTags(listaTags);

                for (int i = 0; i < listaTags.Count; i++)
                {
                    if(i < ListasTagsEvaluados.Item1.Count)
                    {
                        dgvFuncionando.Rows.Add(ListasTagsEvaluados.Item1[i]);
                    }
                    if (i < ListasTagsEvaluados.Item2.Count)
                    {
                        dgvNoReportan.Rows.Add(ListasTagsEvaluados.Item2[i]);
                    }
                    if (i < ListasTagsEvaluados.Item3.Count)
                    {
                        dgvNoSirven.Rows.Add(ListasTagsEvaluados.Item3[i]);
                    }
                }


            }


        }

        /// <summary>
        /// Metodo que realiza la validacion de cada uno de los tags para saber su estado de vida actual
        /// </summary>
        /// <param name="listaTags">Listado de tags paara evaluar</param>
        /// <returns>regresa una tupla con 3 listas de imei (Reportando,NoReporta y NoFunciona)</returns>
       private Tuple<List<string>, List<string>, List<string>> EvaluarTags(List<string> listaTags)
        {
            int estado = 0;
            List<string> Reportando = new List<string>();
            List<string> NoReporta = new List<string>();
            List<string> NoFunciona = new List<string>();


            try
            {
                foreach (string imei in listaTags)
                {
                    Data data = new Data();

                    estado = data.EvaluarTagsReportando(imei);

                    switch (estado)
                    {
                        case 1:
                            Reportando.Add(imei);
                            break;

                        case 2:
                            NoReporta.Add(imei);

                            break;

                        case 3:
                            NoFunciona.Add(imei);

                            break;
                    }
                }

                return new Tuple<List<string>, List<string>, List<string>>(Reportando, NoReporta, NoFunciona);

             }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el disposiivo tag");
                return new Tuple <List<string>, List<string>, List<string>>(Reportando, NoReporta, NoFunciona); ;
            }
           
        }

      
    }
}
