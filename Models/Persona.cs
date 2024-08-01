using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_gestion_empleados.Models;
    public abstract class Persona
    {
        public abstract string Nombre { get; set;}
        public abstract string Apellido { get; set;}
        public abstract int Edad { get; set;}

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public abstract void MostrarInformacion();
    }
