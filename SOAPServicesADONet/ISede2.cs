using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServicesADONet.Entidades;

namespace SOAPServicesADONet
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISede2" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISede2
    {
        [OperationContract]
        List<Sede> listarSedes();
    }
}
