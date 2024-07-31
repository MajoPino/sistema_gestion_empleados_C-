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
            double bonificacion = Salario * 0.1;
            return bonificacion;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine(@$"
 Nombre del empleado: {Nombre} {Apellido}
 Número de identificación: {NumeroIdentificacion}
 Edad del empleado: {Edad} años
 Posición del empleado: {Posicion}
 Salario del empleado: ${Salario} COP
--------------------------------------");
        }
    }
