namespace EvaluarTags
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaTagsConcentrado = new System.Windows.Forms.DataGridView();
            this.ListaTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvFuncionando = new System.Windows.Forms.DataGridView();
            this.dgvNoReportan = new System.Windows.Forms.DataGridView();
            this.dgvNoSirven = new System.Windows.Forms.DataGridView();
            this.Funcionando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoReportan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSirven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaTagsConcentrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoReportan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoSirven)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaTagsConcentrado
            // 
            this.ListaTagsConcentrado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListaTagsConcentrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaTagsConcentrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ListaTags});
            this.ListaTagsConcentrado.Location = new System.Drawing.Point(42, 87);
            this.ListaTagsConcentrado.Name = "ListaTagsConcentrado";
            this.ListaTagsConcentrado.RowTemplate.Height = 24;
            this.ListaTagsConcentrado.Size = new System.Drawing.Size(355, 463);
            this.ListaTagsConcentrado.TabIndex = 1;
            this.ListaTagsConcentrado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaTagsConcentrado_KeyDown);
            // 
            // ListaTags
            // 
            this.ListaTags.HeaderText = "Lista Tags";
            this.ListaTags.Name = "ListaTags";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Limpiar concentrado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Concentrado Tags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(842, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Evaluar Tags";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvFuncionando
            // 
            this.dgvFuncionando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvFuncionando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionando.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcionando});
            this.dgvFuncionando.Location = new System.Drawing.Point(626, 87);
            this.dgvFuncionando.Name = "dgvFuncionando";
            this.dgvFuncionando.ReadOnly = true;
            this.dgvFuncionando.RowHeadersVisible = false;
            this.dgvFuncionando.RowTemplate.Height = 24;
            this.dgvFuncionando.Size = new System.Drawing.Size(182, 463);
            this.dgvFuncionando.TabIndex = 19;
            // 
            // dgvNoReportan
            // 
            this.dgvNoReportan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvNoReportan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoReportan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoReportan});
            this.dgvNoReportan.Location = new System.Drawing.Point(807, 87);
            this.dgvNoReportan.Name = "dgvNoReportan";
            this.dgvNoReportan.ReadOnly = true;
            this.dgvNoReportan.RowHeadersVisible = false;
            this.dgvNoReportan.RowTemplate.Height = 24;
            this.dgvNoReportan.Size = new System.Drawing.Size(182, 463);
            this.dgvNoReportan.TabIndex = 20;
            // 
            // dgvNoSirven
            // 
            this.dgvNoSirven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvNoSirven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoSirven.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoSirven});
            this.dgvNoSirven.Location = new System.Drawing.Point(988, 87);
            this.dgvNoSirven.Name = "dgvNoSirven";
            this.dgvNoSirven.ReadOnly = true;
            this.dgvNoSirven.RowHeadersVisible = false;
            this.dgvNoSirven.RowTemplate.Height = 24;
            this.dgvNoSirven.Size = new System.Drawing.Size(182, 463);
            this.dgvNoSirven.TabIndex = 21;
            this.dgvNoSirven.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Funcionando
            // 
            this.Funcionando.HeaderText = "Funcionando";
            this.Funcionando.Name = "Funcionando";
            this.Funcionando.ReadOnly = true;
            // 
            // NoReportan
            // 
            this.NoReportan.HeaderText = "No Reportan";
            this.NoReportan.Name = "NoReportan";
            this.NoReportan.ReadOnly = true;
            // 
            // NoSirven
            // 
            this.NoSirven.HeaderText = "No funcionan";
            this.NoSirven.Name = "NoSirven";
            this.NoSirven.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 562);
            this.Controls.Add(this.dgvNoSirven);
            this.Controls.Add(this.dgvNoReportan);
            this.Controls.Add(this.dgvFuncionando);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaTagsConcentrado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ListaTagsConcentrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoReportan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoSirven)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ListaTagsConcentrado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListaTags;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvFuncionando;
        private System.Windows.Forms.DataGridView dgvNoReportan;
        private System.Windows.Forms.DataGridView dgvNoSirven;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionando;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoReportan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSirven;
    }
}

