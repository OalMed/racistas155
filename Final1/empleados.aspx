<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empleados.aspx.cs" Inherits="click.empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <style>
    input{
        width:50%;
    }
    form{
        width:60%;
        div{
            display:flex;
            justify-content:right;
        }
    }
    .center{
        justify-content:center;
    }
    #lblMensaje{
        display:none;
    }
</style>

    <center>
        <h1>EMPLEADOS</h1>

        <form id="form1" runat="server">   
            <div>
                Nombre: <asp:TextBox  autofocus ID="nombre" runat="server" title="maximo 50 caracteres"></asp:TextBox>
            </div>
            <div>
                Direccion: <asp:TextBox   ID="dir" runat="server" title="maximo 100 caracteres"></asp:TextBox>
            </div>
                    <div>
                Telefono: <asp:TextBox type="number" MaxLength="10"  ID="tel" runat="server" title="maximo 10 caracteres"></asp:TextBox>
            </div>
                    <div>
                Email: <asp:TextBox type="email"  ID="email" runat="server" title="maximo 70 caracteres"></asp:TextBox>
            </div>

                    <div>
                Puesto: <asp:TextBox   ID="puesto" runat="server" title="maximo 20 caracteres"></asp:TextBox>
            </div>
                    <div>
                Turno: <asp:TextBox   ID="turno" runat="server" title="maximo 10 caracteres"></asp:TextBox>
            </div>

                    <div>
                Sueldo: <asp:TextBox   ID="sueldo" runat="server" type="number"></asp:TextBox>
            </div>
                    <div>
                Fecha de ingreso: <asp:TextBox type="date"  ID="fecha" runat="server" title="maximo 50 caracteres"></asp:TextBox>
            </div>
            <div class="center">
                <asp:Label ID="err" runat="server" ForeColor="Red">MENSAJE</asp:Label>
            </div>
            <div class="center">
                <asp:Button ID="btn" runat="server" OnClick="btn_Click" Text="REGISTRATE" />
            </div>
        </form>
    </center>
</body>
</html>
