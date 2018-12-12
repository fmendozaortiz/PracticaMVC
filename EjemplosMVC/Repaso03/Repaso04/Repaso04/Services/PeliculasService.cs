using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Repaso04.Services
{
    public class PeliculasService
    {
        public static List<Pelicula> ObtenerPelicula()
        {
            var pelicula = new List<Pelicula>();
            for (var i = 1; i <= 10; i++ )
            { 
                pelicula.Add(new Pelicula()
                    {
                        id = i,
                        nombre = "Pelicula " + i
                    });
            }
            return pelicula;   
         }
    }
}