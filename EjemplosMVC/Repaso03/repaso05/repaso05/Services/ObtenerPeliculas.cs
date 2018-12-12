using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repaso05.Services
{
    public class ObtenerPeliculas
    {
        public static List<Pelicula> ListarPelicula()
        {
            var pelicula = new List<Pelicula>();
            for(var a=1;a<=10;a++)
            {
                pelicula.Add(new Pelicula()
                {
                    id=a,
                    NombrePelicula = "Película " + a
                });
            }
            return pelicula;
        }
    }
}