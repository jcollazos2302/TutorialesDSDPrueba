using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;

namespace RESTServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Alumnos" en el código, en svc y en el archivo de configuración a la vez.
    public class Alumnos : IAlumnos
    {
        private AlumnoDAO dao = new AlumnoDAO();

        public Alumno CrearAlumno(Alumno alumnoACrear)
        {
            return dao.Crear(alumnoACrear);
        }

        public Alumno ObtenerAlumno(string codigo)
        {
            return dao.Obtener(codigo);
        }

        public Alumno ModificarAlumno(Alumno alumnoAModificar)
        {
            throw new NotImplementedException();
        }

        public void EliminarAlumno(Alumno alumnoAEliminar)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> ListarAlumnos()
        {
            throw new NotImplementedException();
        }
    }
}
