﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empleados.aspx.cs" Inherits="Final1.empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar empleado</title>
    <link rel="stylesheet" type="text/css"
    href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.1.3/assets/owl.carousel.min.css" />
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    <link href="https://fonts.googleapis.com/css?family=Dosis:400,500|Poppins:400,700&display=swap" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/responsive.css" rel="stylesheet" />
</head>

<body>
      <div class="hero_area">
  <!-- header section strats -->
  <header class="header_section">
    <div class="container-fluid">
      <nav class="navbar navbar-expand-lg custom_nav-container ">
        <a class="navbar-brand" href="indexAdmin.html">
          <img src="images/P2P.png" alt=""/>
            <span>
              Peer to peer
            </span>
        </a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent"
          aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarSupportedContent">
          <div class="d-flex mx-auto flex-column flex-lg-row align-items-center">
            <ul class="navbar-nav  ">
              <li class="nav-item active">
                <a class="nav-link" href="indexAdmin.html">Inicio <span class="sr-only">(current)</span></a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="MenuAdmin.aspx">Administrar</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="Registrate_Original.aspx">Cerrar sesión</a>
              </li>

            </ul>
          </div>
        </div>
      </nav>
    </div>
  </header>
  <!-- end header section -->

</div>

  <center><section class="map_section">
  <div class="form_container">
    <div class="row">
      <div class="col-md-8 col-sm-10 offset-md-2">
        <form action="" id="form1" runat="server">
          <div class="text-center">
            <h3>
              Registrar empleados
            </h3>
          </div>
          <div>
            <asp:TextBox placeholder="Nombre" maxlength="50" autofocus ID="nombre" runat="server" title="maximo 50 caracteres"></asp:TextBox>
          </div>
          <div>
            <asp:TextBox placeholder="Dirección" maxlength="100" ID="dir" runat="server" title="maximo 100 caracteres"></asp:TextBox>
          </div>
          <div>
            <asp:TextBox placeholder="Teléfono" type="tel" ID="tel" runat="server" title="maximo 10 caracteres"></asp:TextBox>
          </div>
          <div>
            <asp:TextBox type="email" MaxLength="70" placeholder="Correo" pattern="^[\w]+@[a-zA-Z]+\.+[a-zA-Z0-9]{1,}" ID="email" runat="server" title="maximo 70 caracteres"></asp:TextBox>
          </div>
          <div>
            <asp:TextBox placeholder="Puesto" maxlength="20" ID="puesto" runat="server" title="maximo 20 caracteres"></asp:TextBox>
          </div>
          <div>
            <asp:TextBox placeholder="Turno" maxlength="10" ID="turno" runat="server" title="maximo 10 caracteres"></asp:TextBox>
          </div>
          <div>
            <asp:TextBox placeholder="Sueldo"  ID="sueldo" runat="server" type="number" step="0.001"></asp:TextBox>
          </div>
          <div>
            <asp:TextBox type="date" placeholder="Fecha de ingreso" ID="fecha" runat="server"></asp:TextBox>
          </div>
          <div class="d-flex justify-content-center">
            <asp:Button ID="btnRegistrar" class="btnEnviar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" />
          </div>
        </form>
      </div>
    </div>
  </div>
  </section></center>


    <section class="info_section layout_padding2">
    <div class="container">
      <div class="info_items">
        <a href="#">
          <div class="item ">
            <div class="img-box box-2">
              <img src="" alt="">
            </div>
            <div class="detail-box">
              <p>
                <b> Contactos: </b><br>
                WhatsApp: 449-214-2135 <br />
                Facebook: PeerToPeer <br />
                Instagram: Peer2Peer
              </p>
            </div>
          </div>
        </a>
        <a href="#">
          <div class="item ">
            <div class="img-box box-3">
              <img src="" alt="">
            </div>
            <div class="detail-box">
              <p>
                peertopeer@dgeti.mx
              </p>
            </div>
          </div>
        </a>
      </div>
    </div>
  </section>
</body>

    <script>
        document.getElementById("fecha").value=new Date().toISOString().split("T")[0]
    </script>
</html>
