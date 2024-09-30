<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrate_Original.aspx.cs" Inherits="Final1.Registrate_Original" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Autentificacion de usuarios</title>
</head>
<body>
    <form id="form1" runat="server">
        <div> <center>
            <h1>SECCIÓN DE AUTENTIFICACIÓN DE USUARIOS</h1> 
            <br />
            <h3>Usuario: 
                <asp:TextBox ID="nom_user" runat="server"></asp:TextBox>
            </h3>
            <h3>Contraseña: 
                <asp:TextBox ID="pass" runat="server"></asp:TextBox>
            </h3> 
            <br />
            <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
            <br />
        </center></div>
    </form>
</body>
</html>
