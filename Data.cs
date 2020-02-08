using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluarTags
{
    public class Data
    {
        public Data() { }

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        /// <summary>
        /// comunicacion con la bd por medio de un SP para evaluar los dispositivos tags
        /// </summary>
        /// <param name="tag">parametro de tipo string para evaluar</param>
        /// <returns>entero con el estado de la evaluacion</returns>
        public int EvaluarTagsReportando(string tag)
        {
            try
            {
                int respuesta = 0;

                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[EvaluarEstadoTagsPorImei]", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sImei", tag);
                cmd.Parameters.Add("@nRespuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToInt32(cmd.Parameters["@nRespuesta"].Value.ToString());

                return respuesta;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

        }
    }
}
