using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using System.ServiceModel.Web;

namespace RESTServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAlumnos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAlumnos
    {
        [OperationContract] 
        [WebInvoke(Method="POST",UriTemplate="Alumnos",ResponseFormat=WebMessageFormat.Json)]
        Alumno CrearAlumno(Alumno alumnoACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Alumnos/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        Alumno ObtenerAlumno(string codigo);

        [OperationContract]
        Alumno ModificarAlumno(Alumno alumnoAModificar);

        [OperationContract]
        void EliminarAlumno(Alumno alumnoAEliminar);

        [OperationContract]
        List<Alumno> ListarAlumnos();


    }
}
