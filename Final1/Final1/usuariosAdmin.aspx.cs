using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data;
using System.Data.SqlClient;

namespace Final1
{
    public partial class usuariosAdmin : System.Web.UI.Page
    {
        ConexionSQL cx;
        protected void Page_Load(object sender, EventArgs e)
        {
            cx = new ConexionSQL("bdprueba");
            //cx = new ConexionSQL("bdprueba", "(local)");

            QuestPDF.Settings.License = LicenseType.Community;
        }
        String strSQL, mensaje = "";

        public void CleanFields()
        {
            txtIdUser.Text = "";
            idUser.Text = "";
            nombre.Text = "";
            correo.Text = "";
            edad.Text = "";
            nom_user.Text = "";
            psw.Text = "";
        }

        public void enableBtns()
        {
            btnUpdate.Visible = true;
            btnEliminar.Visible = true;
        }

        public void disableBtns()
        {
            btnUpdate.Visible = false;
            btnEliminar.Visible = false;
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

                        //mostrarMsj = "<script>alert('" + mensaje + "')</script>";
                        //Response.Write(mostrarMsj);
                        Response.Write(cx.makeAlertText(mensaje));
                        continuar = false;

                        //Int32.Parse("45");
                        return false;
                    }
                    c += 1;
                }
            };
            return true;

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
                strSQL = $"EXEC Bajas {idUser.Text}";
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
                Response.Redirect("usuariosAdmin.aspx");
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

                        idUser.Text = Convert.ToString(cx.datos.Tables["usuarios"].Rows[0]["id_user"]);
                        nombre.Text = Convert.ToString(cx.datos.Tables["usuarios"].Rows[0]["nombre"]);
                        correo.Text = Convert.ToString(cx.datos.Tables["usuarios"].Rows[0]["email"]);
                        edad.Text = Convert.ToString(cx.datos.Tables["usuarios"].Rows[0]["edad"]);
                        nom_user.Text = Convert.ToString(cx.datos.Tables["usuarios"].Rows[0]["nom_user"]);
                        psw.Text = Convert.ToString(cx.datos.Tables["usuarios"].Rows[0]["pass"]);

                    }
                    enableBtns();

                } else
                {
                    mensaje = $"Error al ejecutar la consulta: {cx.exception.Message}";
                }
                Response.Write(cx.makeAlertText(mensaje));
                cx.Close();

            } else
            {
                CleanFields();
                disableBtns();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                cx.Open();

                strSQL = $"EXEC Modificar '{nombre.Text}', '{correo.Text}', {edad.Text}, '{nom_user.Text}', '{psw.Text}', {idUser.Text}";

                if (cx.ejecutarQuery(strSQL))
                {
                    mensaje = "Se modificó al usuario correctamente";
                }
                else
                {
                    mensaje = $"Error al modificar el usuario: {cx.exception.Message}";
                }
                Response.Write(cx.makeAlertText(mensaje));
                cx.Close();
                CleanFields();
                Response.Redirect("usuariosAdmin.aspx");
            }
        }

        protected void btnVerReport_Click(object sender, EventArgs e)
        {
            strSQL = "SELECT * FROM usuarios";
            cx.Open();
            if (cx.ejecutarQuery(strSQL, 4))
            {
                if (cx.datos.Tables["usuarios"].Rows.Count > 0)
                {
                    GenerarPDF();
                }

            }
        }

        public void GenerarPDF()
        {
            var doc = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(30);
                    page.Size(PageSizes.A4);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Header()
                        .Text("Reporte de usuarios")
                        .FontSize(18)
                        .SemiBold()
                        .AlignCenter();

                    page.Content().Element(ComposeContent);
                });
            });

            using (MemoryStream stream = new MemoryStream())
            {
                doc.GeneratePdf(stream);
                stream.Position = 0;
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "attachment;filename=ReporteUsuarios.pdf");
                Response.Buffer = true;
                stream.WriteTo(Response.OutputStream);
                Response.End();
            }

            //Stream stream = new MemoryStream(doc);
            //return File(stream, "application/pdf", "ReporteUsuarios.pdf");
        }

        void ComposeContent (IContainer container)
        {
            container.Column(column =>
            {
                for (int i = 0; i < cx.datos.Tables["usuarios"].Rows.Count; i++)
                {
                    column.Item().Row(row =>
                    {
                        row.RelativeItem().Text($"ID: {cx.datos.Tables["usuarios"].Rows[i]["id_user"]}");
                        row.RelativeItem().Text($"Nombre: {cx.datos.Tables["usuarios"].Rows[i]["nombre"]}");
                        row.RelativeItem().Text($"Email: {cx.datos.Tables["usuarios"].Rows[i]["email"]}");
                        row.RelativeItem().Text($"Edad: {cx.datos.Tables["usuarios"].Rows[i]["edad"]}");
                        row.RelativeItem().Text($"Nombre de usuario: {cx.datos.Tables["usuarios"].Rows[i]["nom_user"]}");
                    });
                    column.Item().PaddingVertical(5).LineHorizontal(0.5f).LineColor(Colors.Black);
                }
            });
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