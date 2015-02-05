using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    public class Mensajes : IMensajes
    {


        public string ObtenerSaludo()
        {
            var hora = DateTime.Now.Hour;
            if (hora < 12)
                return "Buenos dias";
            else if (hora < 19)
                return "Buenas tardes";
            else
                return "Buenas noches";
        }
    }
}
