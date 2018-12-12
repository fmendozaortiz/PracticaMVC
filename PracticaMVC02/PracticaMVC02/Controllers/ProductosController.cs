using PracticaMVC02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaMVC02.Controllers
{
    public class ProductosController : Controller
    {
        List<Datos> producto=new List<Datos>();
        public ProductosController()
        {
            Datos obj1 = new Datos();
            obj1.descripcion = "Manzana";
            obj1.cantidad = 10;
            obj1.precio = 1.50m;
            producto.Add(obj1);

            Datos obj2 = new Datos();
            obj2.descripcion = "Platano";
            obj2.cantidad = 50;
            obj2.precio = 1.20m;
            producto.Add(obj2);
        }
        // GET: /Productos/
        public ViewResult MostrarProductos(int id)
        {
            Datos obj = producto[id];
            return View(obj);
        }
	}
}