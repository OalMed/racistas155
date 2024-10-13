using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final1
{
    public partial class usuariosAdmin : System.Web.UI.Page
    {
        ConexionSQL cx;
        protected void Page_Load(object sender, EventArgs e)
        {
            cx = new ConexionSQL("bdprueba");
            //cx = new ConexionSQL("bdprueba", "(local)");
        }
        String strSQL, mensaje = "";

        public void CleanFields()
        {
            txtIdUser.Text = "";
            nombre.Text = "";
            correo.Text = "";
            edad.Text = "";
            nom_user.Text = "";
            psw.Text = "";
        }

        public Boolean Buscar()
        {            
            strSQL = $"SELECT * FROM usuarios WHERE id_user = {txtIdUser.Text}";
            cx.Open();

            if (cx.ejecutarQuery(strSQL, 3))
            {
                if (cx.existe != null)
                {
                    //cx.Close();
                    return true;
                } else
                {
                    mensaje = "No se encontró a un usuario con ese ID";
                    Response.Write(cx.makeAlertText(mensaje));
                    cx.Close();
                    return false;
                }

            } else
            {
                mensaje = $"Error al buscar el usuario: {cx.exception.Message}";
                Response.Write(cx.makeAlertText(mensaje));
                cx.Close();
                return false;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            cx.Open();
            if (Valido())
            {
                //ConexionSQL cx = new ConexionSQL("bdprueba", "(local)");
                strSQL = $"EXEC Bajas {txtIdUser.Text}";
                //cx.Open();

                if (cx.ejecutarQuery(strSQL))
                {
                    mensaje = "Se eliminó al usuario correctamente";

                }
                else
                {
                    mensaje = $"Error al eliminar el usuario: {cx.exception.Message}";
                }
                Response.Write(cx.makeAlertText(mensaje));
                cx.Close();
                CleanFields();
            } else
            {
                Response.Write("<script>alert('Ingrese un ID')</script>");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cx.Open();
            if (Buscar())
            {
                //ConexionSQL cx = new ConexionSQL("bdprueba", "(local)");
                strSQL = $"SELECT * FROM usuarios WHERE id_user = {txtIdUser.Text}";
                //cx.Open();

                if (cx.ejecutarQuery(strSQL, 4))
                {
                    if (cx.datos.Tables["usuarios"].Rows.Count > 0)
                    {
                        mensaje = "Usuario encontrado";

                        nombre.Text = Convert.ToString(cx.datos.Tables["usuarios"].Rows[0]["nombre"]);
                        correo.Text = Convert.ToString(cx.datos.Tables["usuarios"].Rows[0]["email"]);
                        edad.Text = Convert.ToString(cx.datos.Tables["usuarios"].Rows[0]["edad"]);
                        nom_user.Text = Convert.ToString(cx.datos.Tables["usuarios"].Rows[0]["nom_user"]);
                        psw.Text = Convert.ToString(cx.datos.Tables["usuarios"].Rows[0]["pass"]);

                    } 

                } else
                {
                    mensaje = $"Error al ejecutar la consulta: {cx.exception.Message}";
                }
                Response.Write(cx.makeAlertText(mensaje));
                cx.Close();

            } else
            {
                CleanFields();
            }
        }

        public Boolean Valido()
        {
            if (txtIdUser.Text == "")
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}