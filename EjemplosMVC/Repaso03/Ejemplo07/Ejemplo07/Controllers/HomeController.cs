using Ejemplo07.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo07.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            @ViewBag.paciente = ServicePaciente.ListarPaciente();
            return View();
        }
	}
}