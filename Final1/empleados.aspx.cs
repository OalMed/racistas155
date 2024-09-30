using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyConexion;

namespace click
{
    public partial class empleados : System.Web.UI.Page
    {
        TextBox[] campos;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox[] campos = { nombre, dir, tel, email, puesto, turno, sueldo, fecha };
            this.campos = campos;
        }
        public Boolean ValidarCampos()
        {
            string mensaje = "";
            string mostrarMsj = "";
            
            string[] nombres = { "el nombre","la direccion","el telefono", "el email", "el puesto", "el turno", "la fecha" };
            //Response.Write("<script>alert('EMPIEZA A VALIDAR')</script>");
            Console.WriteLine("empieza");

            int c = 0;
            Boolean continuar = true;

            while (continuar)
            {
                if (c >= this.campos.Length)
                {
                    Response.Write("<script>alert('TODO ESTA CORRECTO')</script>");
                    continuar = false;
                }
                else
                {
                    if (this.campos[c].Text == "")
                    {
                        mensaje = nombres[c] + " no debe estar vacio";
                        //if (c == 2 || c == 4)
                        //{
                        //    mensaje += "a";
                        //}
                        //else
                        //{
                        //    mensaje += "o";
                        //}

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
            for (int index = 0; index < this.campos.Length; index++)
            {
                this.campos[index].Text = "";
            }
        }
        public void conectSQL()
        {
            string strSQL,servidor,db,mensaje="";
            //servidor = "PC02\\SQLEXPRESS";
            servidor = "DESKTOP-RSC2NUF\\SQLEXPRESS";

            db = "dbprueba";

            ConexionSQL cx = new ConexionSQL(db,servidor);

            strSQL = "INSERT INTO empleado " +
                //$"VALUES('{nombre.Text}','{correo.Text}',{edad.Text},'{nom_user.Text}','{psw.Text}')";
                $"VALUES('{nombre.Text}','{dir.Text}','{tel.Text}','{email.Text}','{puesto.Text}','{turno.Text}','{sueldo.Text}','{fecha.Text}')";
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
    }
}