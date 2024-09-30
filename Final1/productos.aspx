<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="Examen1_MartinPerez.productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>PRODUCTOS</title>
    <%--<link type="text/css" href="styles.css"/>--%>
</head>
<body>
	<style>
		body, .container {
			width: 100%;
		}

		.container {
			width:60vh;
			margin-left:calc(( 100vw - 60vh )/ 2 );
			border:2px solid black;
			background-color:gray;
			min-height:90vh;
			section { 
				display:flex;
				flex-direction:column;
				width:45%;
				margin:0px;
				
				input{
					max-width:90%;
					margin-bottom:5%;
				}
			}
		}
		.centro{
			min-width:100%;
			align-items:center;
			button{
				max-width:50%;
			}    
		}
		.l_Izq {
			float:left;
			padding-right:5%;
			.item{
				width:100%;
				text-align:right;
			}
		}
		.item{
			margin-bottom:7%;
		}

		.l_Der {
		}

	</style>

    <form id="form1" class="container" runat="server">
			<section class="centro">
				<center><h1>PRODUCTOS</h1></center>
			</section>
			<section class="l_Izq">
				<div class="item">Nombre</div>
				<div class="item">Descripcion</div>
				<div class="item">Marca</div>
				<div class="item">precio</div>
				<div class="item">existencias</div>
			</section>
			<section class="l_Der">
				<asp:TextBox required type="text" ID="nombre" runat="server"></asp:TextBox>
				<asp:TextBox required type="text" ID="desc" runat="server"></asp:TextBox>
				<asp:TextBox required type="text" ID="marca" runat="server"></asp:TextBox>
				<asp:TextBox required type="number" ID="precio" runat="server"></asp:TextBox>
				<asp:TextBox required type="number" ID="existencias" runat="server"></asp:TextBox>
				
			</section>

			
        <asp:Button runat="server" Text="REGISTRAR" OnClick="Unnamed1_Click"></asp:Button>
		<asp:Button runat="server" ID="redirect" Text="IR A PROVEDORES" OnClick="redirect_Click"></asp:Button>

    </form>

</body>
</html>
