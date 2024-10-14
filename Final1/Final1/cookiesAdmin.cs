using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final1
{
    public class cookiesAdmin : System.Web.UI.Page
    {
        public void createCookie(string nombre, string valor)
        {
            Response.Cookies.Add(new HttpCookie(nombre, valor)
            {
                HttpOnly = true,
                Expires=DateTime.Now.AddDays(3)
            });
        }
        public void deleteCookie(string nombre) {
            Response.Cookies.Add(new HttpCookie(nombre)
            {
                HttpOnly = true,
                Expires = DateTime.Now.AddDays(-1)
            });
            //Request.Cookies.Remove(nombre);
        }
        public string getCookieValue(string nombre)
        {
            try
            {
                return Request.Cookies[nombre].Value;
            }catch (Exception ex)
            {
                return null;
            }
        }
        public void cerrarSesion()
        {
            deleteCookie("nombre");
            deleteCookie("psw");
            deleteCookie("admin");
            Response.Redirect("index.html");
        }
        public string makeAlertText(string messaje)
        {
            return $"<script>alert(`{messaje}`)</script>";
        }
    }
}