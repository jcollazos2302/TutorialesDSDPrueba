using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServicesADONet.Entidades;
using SOAPServicesADONet.DAO;
    
namespace SOAPServicesADONet
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Sede2" en el código, en svc y en el archivo de configuración a la vez.
    public class Sede2 : ISede2
    {

        SedeDAO sedeDAO = new SedeDAO();

        public List<Sede> listarSedes()
        {

            return sedeDAO.ListarSedes().ToList();
            
        }
    }
}
