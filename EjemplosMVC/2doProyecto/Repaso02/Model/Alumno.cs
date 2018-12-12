using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Alumno
    {
        public int id { set; get; }
        public string nombre { set; get; }
        public static List<Alumno>Listar()
        {
            var alumnos = new List<Alumno>();
            for(var i=0;i<=20;i++)
            {
                alumnos.Add(new Alumno()
                {
                    id=i,
                    nombre="Nombre " + i
                });
            }
            return alumnos;
        }
    }
}
