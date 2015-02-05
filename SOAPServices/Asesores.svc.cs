using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Text;
using SOAPServices.Persistencia;
using SOAPServices.Dominio;

namespace SOAPServices
{

    public class Asesores : IAsesores
    {
        private AsesorDAO asesorDAO = null;
        private AsesorDAO AsesorDAO
        {

            get
            {
                if (asesorDAO == null)
                    asesorDAO = new AsesorDAO();

                return asesorDAO;
            }
        }

        private SedeDAO sedeDAO = null;
        private SedeDAO SedeDAO
        {

            get
            {
                if (sedeDAO == null)
                    sedeDAO = new SedeDAO();

                return sedeDAO;
            }
        }


        public Asesor CrearAsesor(string nombre, string correo, int sede)
        {
            Sede sedeExistente=SedeDAO.Obtener(sede);
            Asesor asesorACrear = new Asesor()
            {
                Nombre=nombre,
                Correo=correo,
                Sede=sedeExistente
               
            };

            return AsesorDAO.Crear(asesorACrear);
        }

        public Asesor ObtenerAsesor(int codigo)
        {
            return AsesorDAO.Obtener(codigo);
        }

        public Asesor ModificarAsesor(int codigo, string nombre, string correo, int sede)
        {

            Sede sedeExistente = SedeDAO.Obtener(sede);
            Asesor asesorACrear = new Asesor()
            {
                Codigo=codigo,
                Nombre = nombre,
                Correo = correo,
                Sede = sedeExistente

            };

            return AsesorDAO.Modificar(asesorACrear);

        }

        public void EliminarAsesor(int codigo)
        {
            Asesor asesorExistente = AsesorDAO.Obtener(codigo);
            AsesorDAO.Eliminar(asesorExistente);
        }

        public List<Asesor> ListarAsesores()
        {
            return AsesorDAO.ListarTodos().ToList();
        }
    }  
}
