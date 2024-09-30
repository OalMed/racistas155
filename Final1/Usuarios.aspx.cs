using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyConexion;

namespace click
{
    public partial class form_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblMensaje.Visible = false;
        }
        public string getMachineName()
        {
            
            // Obtiene el nombre del equipo
            string nombreMaquina = Environment.MachineName;

            // Muestra el nombre en la consola
            //"El nombre de la máquina es: " +
            return ( nombreMaquina);
            
        }
        public Boolean ValidarCampos()
        {
            string mensaje = "";
            string mostrarMsj = "";
            TextBox[] campos = { nombre, correo, edad, nom_user, psw };
            string[] nombres = { "el nombre", "el email", "la edad", "el nombre de usuario", "la contraseña" };
            //Response.Write("<script>alert('EMPIEZA A VALIDAR')</script>");
            Console.WriteLine("empieza");

            int c = 0;
            Boolean continuar = true;
            
            while (continuar)
            {
                if(c>= campos.Length)
                {
                    Response.Write("<script>alert('TODO ESTA CORRECTO')</script>");
                    continuar= false;
                }
                else
                {
                    if (campos[c].Text == "")
                    {
                        mensaje = nombres[c] + " no debe estar vaci";
                        if (c == 2 || c == 4)
                        {
                            mensaje += "a";
                        }
                        else
                        {
                            mensaje += "o";
                        }

                        mostrarMsj = "<script>alert('" + mensaje + "')</script>";
                        Response.Write(mostrarMsj);
                        continuar = false;

                        //Int32.Parse("45");
                        return false;
                    }
                    c += 1;
                }
            };
            return true;

        }
        public void cleanFields()
        {
            nombre.Text = "";
            correo.Text = "";
            edad.Text = "";
            nom_user.Text = "";
            psw.Text = "";
        }
        public void conectSQL()
        {
            String strSQL, servidor, mensaje = "";
            //servidor = "PC02\\SQLEXPRESS";
            servidor = "DESKTOP-RSC2NUF\\SQLEXPRESS";

            ConexionSQL cx = new ConexionSQL("bdprueba", servidor);

            strSQL = "INSERT INTO usuarios " +
                $"VALUES('{nombre.Text}','{correo.Text}',{edad.Text},'{nom_user.Text}','{psw.Text}')";

            if (cx.ejecutarQuery(strSQL))
            {
                //consulta exitosa
                mensaje = "El Registro se guardo correctamente";
                cleanFields();
            }
            else
            {
                //consulta fallida
                mensaje = "Error al Guardar el mensaje" + cx.exception.Message;
            }
            Response.Write(cx.makeAlertText(mensaje));
            cx.conexionSQL.Close();

        }
        protected void btn_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                conectSQL();
            }
        }
        //protected void btn_machine
    }
}