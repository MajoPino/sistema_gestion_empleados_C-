using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_gestion_empleados.Models;

    public class Cliente : Persona
    {
        public override string Nombre { get; set; }
        public override string Apellido { get; set; }
        public override int Edad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string apellido, int edad, string email, string telefono) : base (nombre, apellido, edad)
        {
            Email = email;
            Telefono = telefono;
        }

        public override void MostrarInformacion()
        {
            Console.Write($"¦ {Nombre + " " + Apellido,-20} | ");
            Console.Write($" {Edad} años | ");
            Console.Write($"{Telefono,-7} |");
            Console.WriteLine($" {Email,-38}   ¦");
            Console.WriteLine(@$"¦-----------------------------------------------------------------------------------------¦");
        }
    }
