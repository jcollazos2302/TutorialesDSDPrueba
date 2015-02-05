using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTServices.Dominio;
using System.Data.SqlClient;

namespace RESTServices.Persistencia
{
    public class AlumnoDAO
    {

        public Alumno Crear(Alumno alumnoACrear) {

            Alumno alumnoCreado = null;
            string sql = "INSERT INTO t_alummno values(@cod,@nom)";

            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena)) 
            {

                con.Open();

                using (SqlCommand com = new SqlCommand(sql, con)) 
                {

                    com.Parameters.Add(new SqlParameter("@cod", alumnoACrear.Codigo));
                    com.Parameters.Add(new SqlParameter("@nom", alumnoACrear.Nombre));
                    com.ExecuteNonQuery();

                }
            
            }

            alumnoCreado = Obtener(alumnoACrear.Codigo);
            return alumnoCreado;
        
        }
        public Alumno Obtener(string codigo)
        {

            Alumno alumnoEncontrado = null;
            string sql = "SELECT codigo,nombre from t_alumno where codigo=@cod";

            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {

                con.Open();

                using (SqlCommand com = new SqlCommand(sql, con))
                {

                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader()) 
                    {

                        if (resultado.Read()) 
                        {

                            alumnoEncontrado = new Alumno()
                            {

                                Codigo = (string)resultado["codigo"],
                                Nombre = (string)resultado["nombre"]


                            };

                        
                        }

   
                    }


                }

            }

            return alumnoEncontrado;

        }
        public Alumno Modificar(Alumno alumnoAModificar) {

            return null;
        }

        public Alumno Eliminar(Alumno alumnoAEliminar)
        {

            return null;
        }

        public List<Alumno> ListarTodos()
        {

            return null;
        }
        

    }



}