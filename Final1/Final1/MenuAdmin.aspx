<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuAdmin.aspx.cs" Inherits="Final1.MenuAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menú del administrador</title>
</head>
<body>
    <form id="form1" runat="server">
        <div><center>
            <h1> Bienvenido al menú del administrador</h1> 
            <asp:Button ID="GoToUsers" runat="server" Text="Ir a usuarios" />
            <br />
            <br />
            <asp:Button ID="GoToEmpl" runat="server" Text="Ir a empleados" />
            <br />
            <br />
            <asp:Button ID="GoToProd" runat="server" Text="Ir a productos" />
            <br />
            <br />
            <asp:Button ID="GoToProv" runat="server" Text="Ir a proveedores" />
            <br />
        </center> </div>
    </form>
</body>
</html>
