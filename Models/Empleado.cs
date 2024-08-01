using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_gestion_empleados.Models;

    public class Empleado
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroIdentificacion { get; set; }
        public byte Edad { get; set; }
        public string Posicion { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, string apellido, string numeroIdentificacion, byte edad, string posicion, double salario) 
        {
            Id = new Guid();
            Nombre = nombre;
            Apellido = apellido;
            NumeroIdentificacion = numeroIdentificacion;
            Edad = edad;
            Posicion = posicion;
            Salario = salario;
        }

        private double CalcularBonificacion()
        {
            var Bonificacion = Salario * 0.1;
            return Bonificacion;
        }

        public void MostrarInformacion()
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
