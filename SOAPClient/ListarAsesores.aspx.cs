using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SOAPServicesADONet.Entidades;

public partial class ListarAsesores : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {

            ServiceReference2.Asesores2Client asesorCliente = new ServiceReference2.Asesores2Client();
            List<Asesor> listaAsesores = new List<Asesor>();

            listaAsesores=asesorCliente.ListarAsesores().ToList();

            gvAsesores.DataSource = listaAsesores;
            gvAsesores.DataBind();
        
        }

    }
}