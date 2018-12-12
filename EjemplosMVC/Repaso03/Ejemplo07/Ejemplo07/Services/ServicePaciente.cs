using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo07.Services
{
    public class ServicePaciente
    {
        public static List<Paciente> ListarPaciente()
        {
            var pacientes = new List<Paciente>();

            pacientes.Add(new Paciente()
            {
                dni="15844458",
                nombre="Fredy Mendoza",
                estado=true
            });

            pacientes.Add(new Paciente()
            {
                dni = "14852547",
                nombre = "Elizabeth Loayza",
                estado = false
            });

            pacientes.Add(new Paciente()
            {
                dni = "11111111",
                nombre = "Liliana Espericueta",
                estado = true
            });

            return pacientes;
        }
    }
}