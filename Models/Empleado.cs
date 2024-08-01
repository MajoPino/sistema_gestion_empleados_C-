using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_gestion_empleados.Models;

    public class Empleado : Persona
    {
        public override string Nombre { get; set; }
        public override string Apellido { get; set; }
        public override int Edad { get; set; }
        public Guid Id { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Posicion { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, string apellido, int edad, string numeroIdentificacion, string posicion, double salario) : base (nombre, apellido, edad)
        {
            Id = new Guid();
            NumeroIdentificacion = numeroIdentificacion;
            Posicion = posicion;
            Salario = salario;
        }

        private double CalcularBonificacion()
        {
            var Bonificacion = Salario * 0.1;
            return Bonificacion;
        }

        public override void MostrarInformacion()
        {
            var Bonificacion = CalcularBonificacion();
            var salario1 = Salario + Bonificacion;
            string coin = "COP";
            Console.Write($"¦ {Nombre + " " + Apellido,-20} | ");
            Console.Write($"   {NumeroIdentificacion,-11} | {Edad} años | ${salario1:N2} ");
            Console.Write($"{coin,-7} |");
            Console.WriteLine($" {Posicion,-30}   ¦");
            Console.WriteLine(@$"¦------------------------------------------------------------------------------------------------------------¦");
        }
    }
