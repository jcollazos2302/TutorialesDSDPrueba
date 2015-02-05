<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemoAsesores.aspx.cs" Inherits="DemoAsesores" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblLogo" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Datos del asesor"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
&nbsp;<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Correo"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Sede"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlSede" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnProcesar" runat="server" Text="Procesar" 
            onclick="btnProcesar_Click" />
    
    </div>
    </form>
</body>
</html>
