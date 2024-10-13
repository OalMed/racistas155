using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final1
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblMensaje.Visible = false;
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
                if (c >= campos.Length)
                {
                    continuar = false;
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
            String strSQL, servidor =null, mensaje = "";
            //servidor = "PC02\\SQLEXPRESS";
            //servidor = "(local)";

            ConexionSQL cx = new ConexionSQL("bdprueba", servidor);

            strSQL = "INSERT INTO usuarios " +
                $"VALUES('{nombre.Text}','{correo.Text}',{edad.Text},'{nom_user.Text}','{psw.Text}')";
            cx.Open();
            if (cx.ejecutarQuery(strSQL))
            {
                //consulta exitosa
                mensaje = "El Registro se guardo correctamente";
                cleanFields();
                Response.Redirect("Registrate_Original.aspx");
            }
            else
            {
                //consulta fallida
                mensaje = "Error al Guardar el mensaje" + cx.exception.Message;
            }
            Response.Write(cx.makeAlertText(mensaje));
            cx.Close();

        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                conectSQL();
            }
        }
    }
}