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
            <button><a href="empleados.aspx">Ir a empleados</a></button>
            <br />
            <br />
            <button><a href="proveedores.aspx">Ir a proveedores</a></button>
            <br />
            <br />
            <button><a href="productos.aspx">Ir a productos</a></button>
            <br />
        </center> </div>
    </form>
</body>
</html>
