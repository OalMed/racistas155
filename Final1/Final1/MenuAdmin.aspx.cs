using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final1
{
    public partial class MenuAdmin : cookiesAdmin
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoToEmp_Click(object sender, EventArgs e)
        {
            Response.Redirect("empleados.aspx");
        }

        protected void btnGoToProv_Click(object sender, EventArgs e)
        {
            Response.Redirect("proveedores.aspx");
        }

        protected void btnGoToProd_Click(object sender, EventArgs e)
        {
            Response.Redirect("productos.aspx");
        }
        protected void btnGoToUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("usuariosAdmin.aspx");
        }
        protected void cerrarClick(object sender, EventArgs e)
        {
            Response.Write(new ConexionSQL("null").makeAlertText("CERRAR"));
            cerrarSesion();
        }
    }
}