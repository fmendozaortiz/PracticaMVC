using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
    public class HomeController : Controller
    {
        private Alumno alumno = new Alumno();
        public ActionResult Index()
        {
            return View(alumno.Listar());
        }
        public ActionResult Acerca()
        {
            return View();
        }
	}
}