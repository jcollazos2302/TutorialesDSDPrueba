using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAsesores" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAsesores
    {
        [OperationContract]
        Asesor CrearAsesor(string nombre,string correo,int sede);
        [OperationContract]
        Asesor ObtenerAsesor(int codigo);
        [OperationContract]
        Asesor ModificarAsesor(int codigo, string nombre, string correo, int sede);
        [OperationContract]
        void EliminarAsesor(int codigo);
        [OperationContract]
        List<Asesor> ListarAsesores();
    }
}
