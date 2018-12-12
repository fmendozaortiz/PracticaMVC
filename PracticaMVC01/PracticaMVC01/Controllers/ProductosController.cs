using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaMVC01.Controllers
{
    public class ProductosController : Controller
    {
        //
        // GET: /Productos/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar()
        {
            string NombreProducto = RouteData.Values["NombreProducto"].ToString();
            NombreProducto = Server.HtmlEncode(NombreProducto);
            string resultado=string.Empty;

            switch (NombreProducto)
            {
                case "Teclado":
                    {
                        resultado="Disponible 4 unidades";
                        break;
                    }
                case "RAM":
                    {
                        resultado = "Disponible 2 unidades";
                        break;
                    }
                default:
                    {
                        resultado = string.Format("El producto {0} no existe en stock", NombreProducto);
                        break;
                    }
            }
            return Content("<p>" + resultado + "</p>");
        }
	}
}