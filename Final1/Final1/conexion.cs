using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Final1
{
    public class ConexionSQL
    {
        //objetos necesarios para la conexion y el insert
        public SqlConnection conexionSQL;
        public SqlCommand comandosSQL;
        public Exception exception;
        public SqlDataReader leerbd;

        public ConexionSQL(string db, string servidor = null)
        {
            if (servidor == null)
            {
                Console.WriteLine("SERVIDOR =NULL");
                servidor = this.getMachineName() + "\\SQLEXPRESS";
            }

            this.conectar(db, servidor);
        }

        public bool ejecutarQuery(string strSQL, int modo = 1)
        {
            //modos:
            //    1----insert
            //    2----select
            bool result;
            try
            {
                this.conexionSQL.Open();
                this.comandosSQL = new System.Data.SqlClient.SqlCommand(strSQL, this.conexionSQL);

                if (modo == 2)
                {
                    this.leerbd = comandosSQL.ExecuteReader();
                }
                else
                {
                    this.comandosSQL.ExecuteNonQuery();

                }
                Console.WriteLine("CONSULTA EXITOSA");
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("CONSULTA FALLIDA" + ex.Message);
                this.exception = ex;
                result = false;
            }
            if (modo == 1)
            {
                this.conexionSQL.Close();
            }

            return result;
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
        public string getMachineName()
        {

            // Obtiene el nombre del equipo
            string nombreMaquina = Environment.MachineName;

            // Muestra el nombre en la consola
            //"El nombre de la máquina es: " +
            return (nombreMaquina);

        }
        public string makeAlertText(string messaje)
        {
            return $"<script>alert(`{messaje}`)</script>";
        }

        public SqlDataReader getReader()
        {
            return leerbd;
        }
        public void close()
        {
            this.conexionSQL.Close();
        }
    }
}