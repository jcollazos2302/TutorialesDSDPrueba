using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SOAPServicesADONet.Entidades;

public partial class DemoAsesores : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack){
        
        ServiceReference1.LogoClient logoCliente = new ServiceReference1.LogoClient();
        string logo = logoCliente.ObtenerLogo();
        lblLogo.Text = logo;

        ServiceReference3.Sede2Client sedeClient = new ServiceReference3.Sede2Client();
        List<Sede> listaSede=new List<Sede>();

        listaSede = sedeClient.listarSedes().ToList(); 
        ddlSede.DataSource = listaSede;

        ddlSede.DataValueField = "codigo";
        ddlSede.DataTextField = "nombre";
        ddlSede.DataBind();
        

        }



    }
    protected void btnProcesar_Click(object sender, EventArgs e)
    {

        ServiceReference2.Asesores2Client asesorCliente = new ServiceReference2.Asesores2Client();
        Asesor asesor = new Asesor();

        asesor.Nombre = txtNombre.Text;
        asesor.Correo = txtCorreo.Text;
        asesor.Sede = Convert.ToInt32(ddlSede.SelectedValue);

        int resultado = asesorCliente.InsertarAsesor(asesor);

    }
}