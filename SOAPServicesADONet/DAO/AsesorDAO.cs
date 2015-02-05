using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SOAPServicesADONet.Entidades;
using System.Configuration;

namespace SOAPServicesADONet.DAO
{
    public class AsesorDAO
    {
        private string CadenaConexion = ConfigurationManager.AppSettings.Get("CadenaConexion");

        public int RegistrarAsesor(Asesor asesor)
        {
            int resultado;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "usp_asesores_i";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = con;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@nom";
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                param.SqlValue = asesor.Nombre;


                command.Parameters.Add(param);

                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@cor";
                param1.SqlDbType = System.Data.SqlDbType.VarChar;
                param1.SqlValue = asesor.Correo;


                command.Parameters.Add(param1);

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@sede";
                param2.SqlDbType = System.Data.SqlDbType.Int;
                param2.SqlValue = asesor.Sede;


                command.Parameters.Add(param2);
                resultado=command.ExecuteNonQuery();


               
            }

            return resultado;
        }

        public int ModificarAsesor(Asesor asesor)
        {
            int resultado;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "usp_asesores_u";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = con;



                SqlParameter param = new SqlParameter();
                param.ParameterName = "@nom";
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                param.SqlValue = asesor.Nombre;


                command.Parameters.Add(param);

                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@cor";
                param1.SqlDbType = System.Data.SqlDbType.VarChar;
                param1.SqlValue = asesor.Correo;


                command.Parameters.Add(param1);

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@sede";
                param2.SqlDbType = System.Data.SqlDbType.Int;
                param2.SqlValue = asesor.Sede;
                command.Parameters.Add(param2);

                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@cod";
                param3.SqlDbType = System.Data.SqlDbType.Int;
                param3.SqlValue = asesor.Codigo;
                command.Parameters.Add(param3);


                resultado = command.ExecuteNonQuery();

                con.Close();
                command.Dispose();

            }

            return resultado;
        }

        public void EliminarAsesor(int codigo)
        {
            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "usp_asesores_d";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = con;
            con.Open();



            SqlParameter param = new SqlParameter();
            param.ParameterName = "@cod";
            param.SqlDbType = System.Data.SqlDbType.Int;
            param.SqlValue = codigo;


            command.Parameters.Add(param);

            command.ExecuteNonQuery();

            con.Close();
            command.Dispose();

        }



        public Asesor ConsultarAsesor(int codigo)
        {
            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "usp_asesores_g";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = con;
            con.Open();

            

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@cod";
            param.SqlDbType = System.Data.SqlDbType.Int;
            param.SqlValue = codigo;


            command.Parameters.Add(param);

            Asesor asesorObtenido = new Asesor();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    asesorObtenido.Codigo = reader.GetInt32(0);
                    asesorObtenido.Nombre = reader.GetString(1);
                    asesorObtenido.Correo = reader.GetString(2);
                    asesorObtenido.Sede = reader.GetInt32(3);

                }
            }
            return asesorObtenido;

        }

        public List<Asesor> ListarAsesores()
        {
            List<Asesor> listaAsesores = new List<Asesor>();

            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "usp_asesores_gl";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = con;
            con.Open();

            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Asesor asesorObtenido = new Asesor();

                    asesorObtenido.Codigo = reader.GetInt32(0);
                    asesorObtenido.Nombre = reader.GetString(1);
                    asesorObtenido.Correo = reader.GetString(2);
                    asesorObtenido.Sede = reader.GetInt32(3);

                    listaAsesores.Add(asesorObtenido);

                }
            }
            return listaAsesores;

        }


    }
}