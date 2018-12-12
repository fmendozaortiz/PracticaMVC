using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemplosRazor01.Services
{
    public class PeliculaService
    {
        public Pelicula ObtenePelicula()
        {
            return new Pelicula()
            {
                Titulo="Asumare 3",
                Duracion=165,
                Pais="Peru",
                Publicacion=new DateTime(2018,11,25)
            };
        }
        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula01 = new Pelicula()
            {
                Titulo = "Asumare 3",
                Duracion = 165,
                Pais = "Peru",
                Publicacion = new DateTime(2018, 11, 25)
            };
            var pelicula02 = new Pelicula()
            {
                Titulo = "Duro de Matar 2",
                Duracion = 145,
                Pais = "EEUU",
                Publicacion = new DateTime(2018, 11, 20)
            };
            return new List<Pelicula> { pelicula01, pelicula02 };
        }
    }
}