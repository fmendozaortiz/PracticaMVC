using repaso05.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace repaso05.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.peliculas = ObtenerPeliculas.ListarPelicula();
            return View();
        }
	}
}