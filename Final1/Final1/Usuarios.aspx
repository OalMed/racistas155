<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Final1.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar usuario</title>

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
          <a class="navbar-brand" href="index.html">
            <img src="images/v.png" alt="" />
            <span>
              Veterinaria VetPet
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
                  <a class="nav-link" href="index.html">Inicio <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="Usuarios.aspx">Regístrate</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="Registrate_Original.aspx">Iniciar sesión</a>
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
                Regístrate
              </h3>
            </div>
            <div>
                <asp:TextBox placeholder="Nombre" autofocus pattern="^[\D ]{1,50}$" ID="nombre" runat="server" title="maximo 50 caracteres"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox placeholder="Correo" pattern="^[\w]+@[a-zA-Z]+\.+[a-zA-Z0-9]{1,}" ID="correo" runat="server" title="debe contener un @ y uno o varios ."></asp:TextBox>
            </div>
            <div>
                <asp:TextBox placeholder="Edad" ID="edad"  runat="server" title="edad" TextMode="Number" min="1"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox placeholder="Nombre de usuario" pattern="^[\w ]{1,20}" ID="nom_user" runat="server" title="maximo 20 caracteres"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox placeholder="Contraseña" ID="psw" pattern="^[\w ]{1,10}" runat="server" title="maximo 10 caracteres"></asp:TextBox>
                <br />
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
            <div class="img-box box-1">
              <img src="" alt="" />
            </div>
            <div class="detail-box">
              <p>
                <b> Dirección: </b> <br/>
                Héroe Inmortal #630, Morelos I. Aguascalientes, Aguascalientes.
              </p>
            </div>
          </div>
        </a>
        <a href="#">
          <div class="item ">
            <div class="img-box box-2">
              <img src="" alt="">
            </div>
            <div class="detail-box">
              <p>
                <b> Contactos: </b><br>
                Citas: 449-560-4100 <br>
                WhatsApp: 449-214-2135 <br>
                Urgencias 24 h: 449-654-1206
              </p>
            </div>
          </div>
        </a>
        <a href="#">
          <div class="item ">
            <div class="img-box box-3">
              <img src="" alt=""/>
            </div>
            <div class="detail-box">
              <p>
                vetpet@gmail.com
              </p>
            </div>
          </div>
        </a>
      </div>
    </div>
  </section>
</body>
</html>
