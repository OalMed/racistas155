using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        //Se declara y crea un método para validar los usuarios, que devuelve un dato booleano
        public Boolean ValidaUsuarios()
        {
            /*Si la caja de texto del nombre del usuario está vacía, mandará un mensaje que advertirá sobre 
            esto, y devolverá falso, terminando el método.*/
            if (nom_user.Text == "") 
            {
                mensaje = "El campo usuario No debe quedar Vacio";
                MostrarMsj = "<script language='javascript'>alert('" +
                    mensaje + "');<" + "/script>";
                Response.Write(MostrarMsj);
                return false;
            }
            //El siguiente condicional hace lo mismo que con el campo nom_user
            if (pass.Text == "")
            {
                mensaje = "El campo password No debe quedar Vacio";
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

        // Al ejecutarse el evento de click en el boton ingresar, hace lo siguiente
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //Declara un objeto booleano para conocer la validez del formulario, y manda llamar al método ValidarUsuarios()
            Boolean valido;
            valido = ValidaUsuarios();
            // Si el objeto valido es verdadero, ejecuta el siguiente bloque de instrucciones
            if (valido == true)
            {
                /* Si la caja de texto nom_user tiene los caracteres "Administrador" y la caja de texto
                pass tiene los caracteres "123"  */
                if (nom_user.Text == "Administrador" && pass.Text == "123")
                {
                    //Propiedad que redirecciona a otra página
                    Response.Redirect("MenuAdmin.aspx");
                }
                //Declaracion de un objeto booleano con valor falso
                Boolean aceptado = false;
                /*Objeto que contiene el nombre del servidor, el nombre de la BD y la seguridad integrada de la base de datos,
                para conectarse con SQL*/
                String datasource = @"Data Source=PC01\SQLEXPRESS;
                        Initial Catalog=bdprueba;
                        Integrated Security=True;";

                /*Declaramos un objeto conexion de tipo SqlConnection, que nos permitirá hacer la conexion con
                 los parámetros que contiene el objeto "datasource".*/
                SqlConnection conexion = new SqlConnection(datasource);

                /*Declaración de un objeto SqlCommand que ejecuta una consulta en la base de datos
                 */
                conexion.Open();
                SqlCommand consulta = new SqlCommand("select * from usuarios where nom_user='" + nom_user.Text + "' and pass='" + pass.Text + "'", conexion);
                /*Declara un objeto de tipo SqlDataReader que permite almacenar o leer el resultado de una 
                consulta de manera temporal. Y ExecuteReader() es una propiedad que ejecuta la lectura 
                de la consulta almacenada. */
                SqlDataReader leerbd = consulta.ExecuteReader();

                /*Si la consulta toma el valor de verdadero, es decir encuentra un usuario y contraseña que sean 
                iguales a los que están en los campos del formulario, 
                entonces el objeto aceptado toma el valor de verdadero, en caso contrario, será falso. */
                if (leerbd.Read() == true)
                {
                    aceptado = true;
                }
                else
                {
                    aceptado = false;
                }

                /*Si el objeto aceptado es verdadero, entonces redirecciona a la página ofertas*/
                if (aceptado == true)
                {
                    Response.Redirect("Ofertas.aspx");

                }
                /*En caso contrario, mandará un mensaje que dirá que el usuario o contraseña son incorrectos. */
                else
                {
                    mensaje = "USUARIO O CONTRASEÑA INCORRECTA";
                    MostrarMsj = "<script language='javascript'>alert('" +
                        mensaje + "');<" + "/script>";
                    Response.Write(MostrarMsj);
                } 
                // Cierra la conexión
                conexion.Close();
            }
        }

    }
}
