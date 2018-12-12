using PracticaMVC01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaMVC01.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/
        public ActionResult Persona()
        {
            Persona obj = new Persona();
            obj.edad = Convert.ToInt32(Request.Form["txtEdad"]);
            obj.nombre = Request.Form["txtNombre"];
            obj.apellido = Request.Form["txtApellido"];
            return View(obj);
        }
        public ActionResult Index()
        {
            return View();
        }
	}
}