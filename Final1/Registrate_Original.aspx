<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrate_Original.aspx.cs" Inherits="Final1.Registrate_Original" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h3>SECCION DE AUTENTICACION DE USUARiOS</h3>

                <asp:Label ID="Label1" runat="server" Text="USUARIO"></asp:Label>
                <asp:TextBox ID="nom_user" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="CONTRASEÑA"></asp:Label>
                <asp:TextBox ID="pass" runat="server"></asp:TextBox>

                <br />
                <asp:Button ID="Button1" OnClick="btnIngresar_Click" runat="server" Text="Iniciar Sesion" />
            </center>
        </div>
    </form>
</body>
</html>
