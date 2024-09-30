using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyConexion;
using System.Data.SqlClient;

namespace Examen1_MartinPerez
{
    public partial class productos : System.Web.UI.Page
    {
        public SqlConnection conexionSQL;
        public SqlCommand comandosSQL;
        public Exception exception;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void conectar(string db, string servidor)
        {
            String strConexion;
            strConexion =
                $"Data Source={servidor};" + // servidor
                $"Initial Catalog={db};" + // base de datos

                ////Campos extras en caso de necesitar:
                //$"User:{usuario}" +
                //$"Pasword={psw}"

                "Integrated Security=True;";// coinfiguracion de seguridad

            this.conexionSQL = new SqlConnection(strConexion);
        }
        public bool ejecutarQuery(string strSQL)
        {
            bool result;
            try
            {
                this.conexionSQL.Open();
                this.comandosSQL = new System.Data.SqlClient.SqlCommand(strSQL, this.conexionSQL);
                this.comandosSQL.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                this.exception = ex;
                result = false;
            }
            this.conexionSQL.Close();

            return result;
        }
        bool validar_campos()
        {
            return true;
        }
        protected void redirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("provedores.aspx");
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (validar_campos())
            {
                string tabla = "Productos";
                string query = $"INSERT INTO {tabla} VALUES(";

                query += $"'{nombre.Text}','{desc.Text}','{marca.Text}',{precio.Text},{existencias.Text})";
                conectar("BDExamen1", "DESKTOP-RSC2NUF\\SQLEXPRESS");
                if (ejecutarQuery(query))
                {
                    Response.Write("<script>alert('SE INGRESO CON EXITO')</script>");
                }
                else
                {
                    Response.Write($"<script>alert(`ERROR AL INGRESAR LOS DATOS{exception.Message}:{query}`)</script>");
                }

            }

        }
    }
}