using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SOAPServicesADONet.DAO;
using SOAPServicesADONet.Entidades;

namespace SOAPServicesADONet
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    public class Asesores2 : IAsesores2
    {

        AsesorDAO asesorDAO = new AsesorDAO();


        public int InsertarAsesor(Asesor asesor)
        {
            return asesorDAO.RegistrarAsesor(asesor);
        }


        public Asesor ObtenerAsesor(int codigo)
        {

            return asesorDAO.ConsultarAsesor(codigo);

        }


        public int ModificarAsesor(Asesor asesor)
        {
            return asesorDAO.ModificarAsesor(asesor);
        }

        public void EliminarAsesor(int codigo)
        {
            asesorDAO.EliminarAsesor(codigo);
        }

        public List<Asesor> ListarAsesores()
        {
            return asesorDAO.ListarAsesores().ToList();
        }
    }
}
