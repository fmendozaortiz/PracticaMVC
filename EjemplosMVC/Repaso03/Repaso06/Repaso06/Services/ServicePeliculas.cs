using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repaso06.Services
{
    public class ServicePeliculas
    {
        public static List<Pelicula> ObtenerPeliculas()
        {
            var pelicula = new List<Pelicula>();
            for (var a = 1; a <= 10;a++ )
            { 
                pelicula.Add(new Pelicula
                {
                    id=a,
                    nombre="Pelicula " + a
                });
            }
            return pelicula;
        }
    }
}