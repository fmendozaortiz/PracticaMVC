﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;

namespace Repaso02.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            //ViewBag.Alumnos = Alumno.Listar();
            return View(Alumno.Listar());
        }
	}
}