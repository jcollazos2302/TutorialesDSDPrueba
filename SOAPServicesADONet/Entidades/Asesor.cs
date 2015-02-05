using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace SOAPServicesADONet.Entidades
{
    [DataContract]
    public class Asesor
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public int Sede { get; set; }
    }
}