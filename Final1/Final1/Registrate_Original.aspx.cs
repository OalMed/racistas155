using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final1
{
    public partial class Registrate_Original : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            String strSQL, servidor=null;
            //servidor = "PC02\\SQLEXPRESS";
            servidor = "(local)";

            ConexionSQL cx = new ConexionSQL("bdprueba", servidor);

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
                    //Propiedad que redirecciona a otra página
                    Response.Redirect("MenuAdmin.aspx");
                }
            }

            strSQL = $"select * from usuarios where nom_user='{nom_user.Text}' and pass='{pass.Text}'";
            cx.Open();
            if (cx.ejecutarQuery(strSQL, 2))
            {
                /*Si la consulta toma el valor de verdadero, es decir encuentra un usuario y contraseña que sean 
                iguales a los que están en los campos del formulario, 
                entonces redireccionará a Ofertas.aspx, en caso contrario, mandará un mensaje. */
                if (cx.leerbd.Read() == true)
                {
                    cleanFields();
                    Response.Redirect("Ofertas.aspx");
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
            cx.Close();
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
