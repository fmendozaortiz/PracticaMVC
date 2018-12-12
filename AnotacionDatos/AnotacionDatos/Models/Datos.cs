using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnotacionDatos.Models
{
    public class Datos
    {
        [Required(ErrorMessage="El dato Nombre requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El dato Apellido es requerido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El dato Edad es requerido")]
        public int Edad { get; set; }
    }
}