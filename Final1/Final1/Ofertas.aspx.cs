using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final1
{
    public partial class Ofertas : cookiesAdmin
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["nombre"] == null)
            {
                Response.Write(makeAlertText($"Y LAS COOKIES?????'"));
            }
            Response.Write(makeAlertText($"BIENVENIDO {getCookieValue("nombre")}"));
        }
        protected void cerrarClick(object sender, EventArgs e)
        {
            deleteCookie("nombre");
            deleteCookie("psw");
            deleteCookie("admin");
            Response.Redirect("index.html");
        }
    }
}