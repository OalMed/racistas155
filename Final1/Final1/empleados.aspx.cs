﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final1
{
    public partial class empleados : System.Web.UI.Page
    {
        TextBox[] campos;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox[] campos = { nombre, dir, tel, email, puesto, turno, sueldo, fecha };
            this.campos = campos;
        }
        public string getMachineName()
        {

            // Obtiene el nombre del equipo
            string nombreMaquina = Environment.MachineName;

            // Muestra el nombre en la consola
            //"El nombre de la máquina es: " +
            return (nombreMaquina);

        }
        public Boolean ValidarCampos()
        {
            string mensaje = "";
            string mostrarMsj = "";
            string[] nombres = { "El nombre", "La dirección", "El teléfono", "El correo", "El puesto", "El turno", "El sueldo", "La fecha" };
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
                        if (c == 1 || c == 7)
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
            for (int index = 0; index < this.campos.Length; index++)
            {
                this.campos[index].Text = "";
            }
        }
        public void conectSQL()
        {
            String strSQL, servidor, mensaje = "";
            //servidor = "PC02\\SQLEXPRESS";
            servidor = "(local)";

            ConexionSQL cx = new ConexionSQL("bdprueba", servidor);

            strSQL = "INSERT INTO empleados " +
                $"VALUES('{nombre.Text}','{dir.Text}',{tel.Text},'{email.Text}','{puesto.Text}','{turno.Text}',{sueldo.Text},'{fecha.Text}')";

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
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                conectSQL();
            }
        }
    }
}