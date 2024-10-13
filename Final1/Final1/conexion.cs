using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Final1
{
    public class ConexionSQL
    {
        //objetos necesarios para la conexion y el insert
        public SqlConnection conexionSQL;
        public SqlCommand comandosSQL;
        public SqlDataAdapter adapter;
        public string otroMess;
        public Exception exception;
        public SqlDataReader leerbd;
        public Object existe;
        public DataSet datos;

        public ConexionSQL(string db, string servidor = null)
        {
            if (servidor == null)
            {
                Console.WriteLine("SERVIDOR =NULL");
                servidor = this.getMachineName() + "\\SQLEXPRESS";
            }
            /*if (servidor == "(local)")
            {
                servidor += "\\SQLEXPRESS";
            }*/

            this.conectar(db, servidor);
        }

        public void Open()
        {
            this.conexionSQL.Open();
        }
        public void Close()
        {
            this.conexionSQL.Close();
        }
        public bool ejecutarQuery(string strSQL, int modo = 1)
        {
            //modos:
            //    1----insert
            //    2----select
            //    3----select con ExecuteScalar()
            //    4----select con SqlDataAdapter y DataSet
            otroMess = "";
            bool result;
            bool failedOpen=true;
            try
            {
                
                failedOpen=false;
                this.comandosSQL = new SqlCommand(strSQL, this.conexionSQL);

                if (modo == 2)
                {
                    this.leerbd = comandosSQL.ExecuteReader();
                }
                else if (modo == 3)
                {
                    this.existe = new Object();
                    this.existe = this.comandosSQL.ExecuteScalar();
                }
                else if (modo == 4)
                {
                    this.datos = new DataSet();
                    this.adapter = new SqlDataAdapter(this.comandosSQL);
                    this.adapter.Fill(this.datos, "usuarios");
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
                if (failedOpen) {
                    otroMess = "error en el open";
                }
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

                "Integrated Security=True;";// configuracion de seguridad

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
            return $"<script>alert(`{messaje}#__{otroMess}`)</script>";
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