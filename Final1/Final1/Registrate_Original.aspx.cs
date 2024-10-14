using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
//using System.Web.UI.WebControl;

namespace Final1
{
    public partial class Registrate_Original : cookiesAdmin
    {
        ConexionSQL cx;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie nombre, psw;

            nombre = Request.Cookies["nombre"];
            psw = Request.Cookies["psw"];

            if (!(nombre == null && psw == null))
            {
                //existen ambas cookies y por ende, ya habias iniciado sesion
                //nom_user.Text = nombre.Value;
                //pass.Text = psw.Value;
                //conectSQL();

                if (getCookieValue("admin")=="true")
                {
                    //es admin
                    Response.Redirect("MenuAdmin.aspx");
                }
                else
                {
                    //no es admin
                    Response.Redirect("Ofertas.aspx");
                }
            }

            String servidor = null;
            //servidor = "PC02\\SQLEXPRESS";
            //servidor = "local\\SQLEXPRESS";
            servidor = null;
            cx = new ConexionSQL("bdprueba", servidor);

            //if (cx.Open())
            //{
            //    Response.Write(cx.makeAlertText("conexion abierta"));
            //    cx.Close();
            //}
            //else{
            //    Response.Write(cx.makeAlertText($"error al abrir: {cx.exception.Message}"));
            //}
        }

        // Declarar las siguientes variables globales en el codigo: 

        string mensaje = "";
        string MostrarMsj = "";
        public void cleanFields()
        {
            nom_user.Text = "";
            pass.Text = "";
        }

        //Se declara y crea un método para validar los usuarios, que devuelve un dato booleano
        public Boolean ValidaUsuarios()
        {
            /*Si la caja de texto del nombre del usuario está vacía, mandará un mensaje que advertirá sobre 
            esto, y devolverá falso, terminando el método.*/
            if (nom_user.Text == "") 
            {
                mensaje = "El campo del nombre de usuario no debe quedar vacío";
                MostrarMsj = "<script language='javascript'>alert('" +
                    mensaje + "');<" + "/script>";
                Response.Write(MostrarMsj);
                return false;
            }
            //El siguiente condicional hace lo mismo que con el campo nom_user
            if (pass.Text == "")
            {
                mensaje = "El campo de la contraseña no debe quedar vacío";
                MostrarMsj = "<script language='javascript'>alert('" +
                    mensaje + "');<" + "/script>";
                Response.Write(MostrarMsj);
                return false;
            }
            // Si ningun campo es vacío, entonces termina el método devolviendo verdadero
            else
            {
                return true;
            }

        }

        public void conectSQL()
        {
            string redir=getRedirect();

            if (redir != "")
            {
                //calzaron los valores nombre y usuario, por lo que si existes
                
                createCookie("nombre", nom_user.Text);
                createCookie("psw", pass.Text);

                if(redir== "MenuAdmin.aspx")
                {
                    createCookie("admin", "true");
                }
                else
                {
                    createCookie("admin", "false");
                }
                //Response.Write("redir="+redir+"<br>nom_user="+ nom_user.Text + "<br>nombre cookie="+getCookieValue("nombre")+"<br>es admin?=" + getCookieValue("admin"));
                Response.Redirect(redir);
                //nom_user.Text, pass.Text
            }
        }
        public string getRedirect() 
        {
            //Creación de un diccionario que contiene el nombre de los administradores y sus contraseñas.
            Dictionary<string, string> admins = new Dictionary<string, string>
            {
                {"Administrador" , "12345"},
                {"Oscar" , "jelouworld"},
                {"Martin" , "martingpt"}
            };

            /*Recorre el diccionario comparando si el contenido de las cajas de texto nom_user y pass coinciden con algún
            administrador guardado en el diccionario. */
            foreach (KeyValuePair<string, string> x in admins)
            {
                if (x.Key == nom_user.Text && x.Value == pass.Text)
                {
                    /*if (Request.Cookies["userInfo"] != null)
                    {
                        HttpCookie cookie2 = Request.Cookies["userInfo"];
                        cookie2.Values.Remove("user");
                        Response.Cookies.Add(cookie2);
                    }
                    //Creación de una cookie para manejar las sesiones de forma simple
                    this.cookie["admin"] = nom_user.Text;
                    Response.Cookies.Add(cookie);*/

                    //Propiedad que redirecciona a otra página

                    //Response.Redirect("MenuAdmin.aspx");
                    return "MenuAdmin.aspx";
                }
            }
            String strSQL;

            strSQL = $"select * from usuarios where nom_user='{nom_user.Text}' and pass='{pass.Text}'";
            cx.Open();
            if (cx.ejecutarQuery(strSQL, 2))
            {
                /*Si la consulta toma el valor de verdadero, es decir encuentra un usuario y contraseña que sean 
                iguales a los que están en los campos del formulario, 
                entonces redireccionará a Ofertas.aspx, en caso contrario, mandará un mensaje. */
                bool res = cx.leerbd.Read();
                cx.Close();
                if (res == true)
                {
                    /*if (Request.Cookies["userInfo"] != null)
                    {
                        HttpCookie cookie2 = Request.Cookies["userInfo"];
                        cookie2.Values.Remove("admin");
                        Response.Cookies.Add(cookie2);
                    }
                    this.cookie["user"] = nom_user.Text;
                    Response.Cookies.Add(cookie);*/
                    return "Ofertas.aspx";
                    //cleanFields();
                    //Response.Redirect("Ofertas.aspx");
                }
                else
                {
                    mensaje = "USUARIO O CONTRASEÑA INCORRECTA";
                }
            }
            else
            {
                mensaje = "Error al hacer la consulta: " + cx.exception.Message;
            }

            Response.Write(cx.makeAlertText(mensaje));
            //cx.Close();
            return "";
        }

        // Al ejecutarse el evento de click en el boton ingresar, hace lo siguiente
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidaUsuarios())
            {
                conectSQL();
            }
        }

    }
}
