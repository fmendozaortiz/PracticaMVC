using Repaso04.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repaso04.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
           // var peliculaService=new 
            ViewBag.pelicula = PeliculasService.ObtenerPelicula();
            var persona = new Persona()
            {
                Nombre = "Fredy Mendoza",
                Edad = 45,
                Empleado=true,
                Nacimiento=new DateTime(1973,2,18)
            };
            ViewBag.valor = persona;
            return View();
        }

        [ChildActionOnly]
        public ActionResult Acerca()
        {
            return View();
        }
	}

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Empleado { get; set; }
        public DateTime Nacimiento { get; set; }
    }
}