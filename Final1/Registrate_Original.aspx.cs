using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyConexion;

namespace Final1
{
    public partial class Registrate_Original : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cx = new ConexionSQL("bdprueba");
        }
        // Declarar las siguientes variables en el codigo: 

        string mensaje = "";
        string MostrarMsj = "";
        ConexionSQL cx;

        public Boolean ValidaUsuarios()
        {
            if (nom_user.Text == "")
            {
                mensaje = "El campo usuario No debe quedar Vacio";
                MostrarMsj = "<script language='javascript'>alert('" +
                    mensaje + "');<" + "/script>";
                Response.Write(MostrarMsj);
                return false;
            }
            if (pass.Text == "")
            {
                mensaje = "El campo password No debe quedar Vacio";
                MostrarMsj = "<script language='javascript'>alert('" +
                    mensaje + "');<" + "/script>";
                Response.Write(MostrarMsj);
                return false;
            }
            else
                return true;

        }

        //Dentro del boton de Acceder ingresar el siguiente codigo:

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            Boolean valido;
            valido = ValidaUsuarios();
            if (valido == true)
            {
                if (nom_user.Text == "Admin" && pass.Text == "123")
                {
                    Response.Redirect("MenuAdmin.aspx");
                }
                Boolean aceptado = false;
                //String datasource = @"Data Source=(local);
                //        Initial Catalog=bd_proy5A;
                //        Integrated Security=True;";
                //SqlConnection conexion = new SqlConnection(datasource);
                //SqlCommand consulta = new SqlCommand("select * from Usuarios where nom_user='" + nom_user.Text + "' and pass='" + pass.Text + "'", conexion);                                                                                                                                                                                                                                                                                                                                                                                      
                //conexion.Open();
                //SqlDataReader leerbd = consulta.ExecuteReader();

                cx.ejecutarQuery($"select * from usuarios where nom_user='{nom_user.Text }' and pass='{pass.Text }'",2);

                if (cx.getReader().Read() == true)
                {
                    aceptado = true;
                }
                else
                {
                    aceptado = false;
                }

                if (aceptado == true)
                {
                    Response.Write(cx.makeAlertText("BIENVENIDO"));
                    Response.Redirect("Ofertas.aspx");

                }
                else
                {
                    Response.Write(cx.makeAlertText("USUARIO O CONTRASEÑA INCORRECTA"));
                }
                cx.close();
                //conexion.Close();
            }
        }

    }
}