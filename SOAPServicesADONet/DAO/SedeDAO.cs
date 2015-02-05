using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SOAPServicesADONet.Entidades;
using System.Configuration;


namespace SOAPServicesADONet.DAO
{
    public class SedeDAO
    {
        private string CadenaConexion = ConfigurationManager.AppSettings.Get("CadenaConexion");

        public List<Sede> ListarSedes()
        {
            List<Sede> listaSedes = new List<Sede>();

            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "usp_sedes_gl";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = con;
            con.Open();


            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Sede sede = new Sede();

                    sede.Codigo = reader.GetInt32(0);
                    sede.Nombre = reader.GetString(1);


                    listaSedes.Add(sede);

                }
            }
            return listaSedes;

        }

    }
}