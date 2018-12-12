using EjemplosRazor01.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemplosRazor01.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var peliculaService = new PeliculaService();
            var model = peliculaService.ObtenerPeliculas();
            return View(model);
        }
	}
}