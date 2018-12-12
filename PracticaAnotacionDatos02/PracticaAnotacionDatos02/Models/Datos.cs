using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaAnotacionDatos02.Models
{
    public class Datos
    {
        [Required(ErrorMessage="Debe ingresar el nombre")]
        public string Nombres { get; set; }

        [Required(ErrorMessage="Debe ingresar el apellido")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage="Debe ingresar la edad")]
        public string Edad { get; set; }

    }
}