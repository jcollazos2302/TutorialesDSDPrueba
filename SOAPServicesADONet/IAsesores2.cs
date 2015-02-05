using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SOAPServicesADONet.Entidades;

namespace SOAPServicesADONet
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAsesores2
    {

        [OperationContract]
        int InsertarAsesor(Asesor asesor);

        [OperationContract]
        Asesor ObtenerAsesor(int codigo);

        [OperationContract]
        int ModificarAsesor(Asesor asesor);

        [OperationContract]
        void EliminarAsesor(int codigo);

        [OperationContract]
        List<Asesor> ListarAsesores();

    }


    }
