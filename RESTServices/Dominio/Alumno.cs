using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTServices.Dominio
{
    [DataContract]
    public class Alumno
    {

        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Nombre { get; set; }

    }
}