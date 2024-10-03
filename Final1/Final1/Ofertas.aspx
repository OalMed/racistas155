<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ofertas.aspx.cs" Inherits="Final1.Ofertas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ofertas</title>
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
        <a class="navbar-brand" href="indexUser.html">
          <img src="images/v.png" alt=""/>
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
                <a class="nav-link" href="indexUser.html">Inicio <span class="sr-only">(current)</span></a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="Ofertas.aspx">Ofertas</a>
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

    <section class="client_section layout_padding-bottom">
  <div class="container">
    <h2 class="custom_heading text-center">
      Ofertas
    </h2>
    <!--div id="carouselExample2Indicators" class="carousel slide" data-ride="carousel">
      <ol class="carousel-indicators">
        <li data-target="#carouselExample2Indicators" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExample2Indicators" data-slide-to="1"></li>
        <li data-target="#carouselExample2Indicators" data-slide-to="2"></li>
      </ol>
      <div class="carousel-inner">
        <div class="carousel-item active">
          <div class="layout_padding2 pl-100">
            <div class="client_container ">
              <div class="img_box">
                <img src="images/loros1.png" alt=""> <br> <br>
  <img src="images/loros2.png" alt="">
              </div>
              <div class="detail_box">
                <h4 class="custom_heading text-center"><b> Loros 
                </b></h4>
                <h5 class="custom_heading">
                  ¿Qué son los <span>loros</span>?
                </h5>
                <p>
                  Los loros (Psittacoidea) son una superfamilia del orden Psittaciformes, 
                  con un total de 369 especies. Los loros típicos son más numerosos y están 
                  más extendidos que las otras superfamilias de psitaciformes, las cacatúas 
                  y los escasos y confinados loros de Nueva Zelanda.
                </p>
                <h5 class="custom_heading">
                  Características de los <span>loros</span>
                </h5>
  <p>
                  Todos los loros tienen picos curvos y son zigodáctilos, es decir que 
                  tienen cuatro dedos en cada pie: dos apuntando hacia adelante y dos hacia 
                  atrás. La mayoría de los loros comen frutas, flores, capullos, nueces, 
                  semillas y algunas criaturas pequeñas, como insectos. <br>
                  Otra característica de los loros es la intensa coloración de su plumaje. 
                  El color predominante del plumaje de los loros es el verde, aunque la 
                  mayoría de las especies tienen además algo de rojo, azul, amarillo y otros 
                  colores en diversas cantidades. <br>
                  Los miembros de Psittacoidea son especies predominantemente monógamas 
                  que suelen anidar en cavidades (de árboles o túneles). Algunas especies 
                  pueden imitar gran diversidad de sonidos, incluida la voz humana, entre 
                  otros sonidos de su entorno.
  </p>
                <h5 class="custom_heading">
                  Hábitat de los <span>loros</span>
                </h5>
                <p>
                  Generalmente viven en regiones tropicales o cálidas. Los loros se 
                  extienden por el hemisferio sur, además de la región tropical y 
                  subtropical del hemisferio norte; distribuidos por el sur de Asia, 
                  el África subsahariana, Oceanía, América del Sur y Central, y en el 
                  pasado había una especie nativa de Norteamérica.
                </p>
                <h5 class="custom_heading">
                  Amenazas de los <span>loros</span>
                </h5>
                <p>
                  Muchas especies del grupo están clasificadas en peligro de extinción. 
                  La captura de loros salvajes para el tráfico de mascotas (que sufren 
                  más que las demás aves), la destrucción de su hábitat y la competencia 
                  con especies invasoras, han disminuido las poblaciones salvajes. Esta 
                  combinación de factores ha expulsado a muchas especies de la mayor parte 
                  del área de distribución que tenían a principios del siglo XX. <br>
                  Muy pocos de los loros sacados de su hábitat natural sobrevive a su 
                  captura, transporte y al estrés que sufren en cautividad. <br>
                  Aunque la Convención sobre el Comercio Internacional de Especies 
                  Amenazadas (CITES) prohíbe la venta de cualquier especie capturada 
                  en la naturaleza, la popularidad de los loros continúa impulsando el 
                  comercio ilegal.
                </p>
                <h5 class="custom_heading">
                  Fuentes
                </h5>
                <p>
                   <ul>
                      <li>https://es.wikipedia.org/wiki/Psittacoidea
                      <li>https://www.nationalgeographicla.com/animales/loros
                   </ul>
                <p>
              </div>
            </div>
          </div>
        </div>
        <div class="carousel-item">
          <div class="layout_padding2 pl-100">
            <div class="client_container ">
              <div class="img_box">
                <img src="images/perros1.png" alt=""> <br> <br>
  <img src="images/perros2.png" alt="">
              </div>
              <div class="detail_box">
                <h4 class="custom_heading text-center"><b> Perros 
                </b></h4>
                <h5 class="custom_heading">
                  ¿Qué son los <span>perros</span>?
                </h5>
                <p>
                 El perro (Canis familiaris o Canis lupus familiaris, dependiendo de si se 
                 lo considera una especie por derecho propio o una subespecie del lobo), 
                 llamado perro doméstico o can, es un mamífero carnívoro de la familia de 
                 los cánidos, que constituye una especie del género Canis. <br>
                 Su tamaño, su forma y su pelaje es muy diverso y varía según la raza. 
                 Posee un oído y un olfato muy desarrollados, y este último es su principal 
                 órgano sensorial. Su longevidad media es de diez a trece años, dependiendo 
                 de la raza.
                </p>
                <h5 class="custom_heading">
                  Características de los <span>perros</span>
                </h5>
                <p>
                 En comparación con lobos de tamaño equivalente, los perros tienden a tener 
                 el cráneo un 20 % más pequeño y el cerebro un 10 % más pequeño, además de 
                 tener los dientes más pequeños que otras especies de cánidos. El perro 
                 requiere menos calorías para vivir que el lobo. Su dieta de sobras de los 
                 humanos hizo que su cerebro grande y los músculos mandibulares utilizados 
                 en la caza dejaran de ser necesarios. <br>
                 La piel del perro doméstico tiende a ser más gruesa que la del lobo. Sus 
                 patas suelen ser más cortas que las de un lobo y su cola tiende a curvarse 
                 hacia arriba.
                </p>
                <h5 class="custom_heading">
                  Hábitat de los <span>perros</span>
                </h5>
                <p>
                 No existen límites para definir un hábitat preferido para los perros, 
                 pueden adaptarse, siempre y cuando exista disponibilidad de alimentos y 
                 agua. Ellos pueden sobrevivir desde los 0 msnm hasta las grandes alturas, 
                 así mismo sobreviven a climas extremadamente cálidos y fríos. De igual 
                 manera, están distribuidos por todo el mundo; cada raza adaptada a la 
                 región en la que está.
                </p>
                <h5 class="custom_heading">
                  Datos sobre su <span>alimentación</span>
                </h5>
                <p>
                 El perro doméstico es omnívoro, con una dieta a base de carne. Aunque 
                 se deben evitar ciertos alimentos, como chocolate, golosinas, huesos 
                 (de pollo o aquellos fácilmente astillables), desperdicios caseros, carne 
                 de cerdo o jabalí, entre otros alimentos. <br>
                 Las poblaciones ferales pueden tener un impacto importante sobre la fauna 
                 nativa como depredador.
                </p>
                <h5 class="custom_heading">
                  Fuentes
                </h5>
                <p>
                   <ul>
                      <li>https://es.wikipedia.org/wiki/Canis_familiaris
                      <li>https://www.darwinfoundation.org/es/datazone/checklist?species=5205#:~:text=
                      Preferencias%20de%20habitat%3A%20No%20existen,climas%20extremadamente
                      %20c%C3%A1lidos%20y%20fr%C3%ADos.
                   </ul>
                </p>
              </div>
            </div>
          </div>
        </div>
        <div class="carousel-item">
          <div class="layout_padding2 pl-100">
            <div class="client_container ">
              <div class="img_box">
                <img src="images/hams1.png" alt=""> <br> <br>
  <img src="images/hams2.png" alt="">
              </div>
              <div class="detail_box">
  <h4 class="custom_heading text-center"><b> Hámsteres 
                </b></h4>
                <h5 class="custom_heading">
                  ¿Qué son los <span>hámsteres</span>?
                </h5>
                <p>
                  Los cricetinos (Cricetinae) son una subfamilia de roedores, conocidos 
                  comúnmente como hámsteres. La mayoría son originarias de Oriente Medio 
                  y del sureste de los Estados Unidos. Todas las especies se caracterizan 
                  por las bolsas expansibles, llamadas abazones, ubicadas en el interior 
                  de la boca y que van desde las mejillas hasta los hombros.
                </p>
                <h5 class="custom_heading">
                  Características de los <span>hámsteres</span>
                </h5>
                <p>
                  Su esperanza de vida es de año y medio a tres años, aunque existen 
                  variaciones según la especie, pero no pasan de los cuatro años. Pesan 
                  de 30-40 gramos en algunas especies, en otras de 100-180 gramos. Su 
                  longitud es de 8-18 centímetros. Su periodo de gestación va de 15 a 
                  21 días. Todas estas características varían según la especie, pero ese 
                  es el rango promedio.
                </p>
                <h5 class="custom_heading">
                  Hábitat de los <span>hámsteres</span>
                </h5>
                <p>
                  La mayoría son nativos de Estados Unidos, Asia u Oriente Medio, pero 
                  también habitan China y lugares de Europa. Aquellos que sonn salvajes 
                  hacen madrigueras u hoyos en el suelo, que llegan a medir, incluso, 
                  2 metros de profundidad, y estos sirven para resguardarse de sus depredadores.
                </p>
                <h5 class="custom_heading">
                  Datos sobre su <span>alimentación</span>
                </h5>
                <p>
                  Algunas especies son omnívoras, pero la mayoría se alimentan de semillas 
                  o algunos frutos secos, y ocasionalmente de insectos, así como algunos 
                  cereales.
                </p>
                <h5 class="custom_heading">
                  Fuentes
                </h5>
                <p>
                   <ul>
                      <li>https://www.nacionrex.com/random/donde-vive-un-hamster-habitat-natural-y-
                       alimentacion-20180216-0033.html
                      <li>https://es.wikipedia.org/wiki/Cricetinae
                      <li>https://www.tiendanimal.es/articulos/que-comen-los-hamster/#:~:text=
                       Una%20dieta%20equilibrada%20para%20h%C3%A1msters,%2C%20carne%2
                       C%20queso%20y%20yogur.
                   </ul>
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div-->
  </div>

</section>

      <section class="info_section layout_padding2">
  <div class="container">
    <div class="info_items">
      <a href="#">
        <div class="item ">
          <div class="img-box box-1">
            <img src="" alt="">
          </div>
          <div class="detail-box">
            <p>
              <b> Dirección: </b> <br>
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
            <img src="" alt="">
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
