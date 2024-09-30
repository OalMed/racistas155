<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="click.form_" %>

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
        <h1>LOGIN</h1>
        <form id="form1" runat="server">
            <div>
                Nombre: <asp:TextBox  autofocus pattern="^[\D ]{1,50}$" ID="nombre" runat="server" title="maximo 50 caracteres"></asp:TextBox>
            </div>
            <div>
                Correo: <asp:TextBox  pattern="^[\w]+@[a-zA-Z]+\.+[a-zA-Z0-9]{1,}" ID="correo" runat="server" title="debe contener un @ y uno o varios ."></asp:TextBox>
            </div>
            <div>
                <%--pattern="^[\d]{1,}"--%>
                Edad: <asp:TextBox  ID="edad"  runat="server" title="edad"></asp:TextBox>
            </div>
            <div>
                Nombre der Usuario: <asp:TextBox  pattern="^[\w ]{1,20}" ID="nom_user" runat="server" title="maximo 20 caracteres"></asp:TextBox>
            </div>
            <div>
                Contraseña: <asp:TextBox  ID="psw" pattern="^[\w ]{1,10}" runat="server" title="maximo 10 caracteres"></asp:TextBox>
                <br />
            </div>
            <div class="center">
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red">MENSAJE</asp:Label>
            </div>
            
            <div class="center">
                <asp:Button ID="btn" runat="server" OnClick="btn_Click" Text="REGISTRATE" />
            </div>

            <%--<div class="center">
                <asp:Button ID="machine" runat="server" OnClick="btn_machine" Text="REGISTRATE" />
            </div>--%>
        </form>
    </center>
</body>
</html>
