using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_gestion_empleados.Models;

public class Empresa : Empleado
{
    public string NombreEmpresa { get; set; }
    public string Direccion { get; set; }
    public static List<Empleado> ListaEmpleados = new List<Empleado>();

    public Empresa(string nombre, string apellido, string numeroIdentificacion, byte edad, string posicion, double salario, string nombreEmpresa, string direccion) : base(nombre, apellido, numeroIdentificacion, edad, posicion, salario)
    {
        NombreEmpresa = nombreEmpresa.Trim();
        Direccion = direccion.Trim();
    }

    public static void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
    }

    public static void EliminarEmpleado()
    {
        var empleado = BuscarEmpleado();

        if (empleado != null)
        {
            ListaEmpleados.Remove(empleado);
            Console.WriteLine("Empleado eliminado correctamente!");
        }
    }

    public static void MostrarTodosLosEmpleados()
    {
        foreach (Empleado empleado in ListaEmpleados)
        {
            empleado.MostrarInformacion();
        }
    }

    public static void ActualizarEmpleado()
    {
        var empleado = BuscarEmpleado();

        if (empleado != null)
        {
            Console.Write("Nombre: ");
            string Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string Apellido = Console.ReadLine();
            Console.Write("Edad: ");
            byte Edad = Convert.ToByte(Console.ReadLine());
            Console.Write("Posición: ");
            string Posicion = Console.ReadLine();
            Console.Write("Salario: ");
            double Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Empleado actualizado correctamente!");
        }
    }

    public static Empleado BuscarEmpleado()
    {
        Console.Write("Ingrese el número de identificación del empleado a buscar: ");
        string numeroIdentificacion = Console.ReadLine();
        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroIdentificacion == numeroIdentificacion);
        if (empleado != null)
        {
            empleado.MostrarInformacion();
        }
        else
        {
            Console.WriteLine("No se encontró el empleado, por favor intente de nuevo.");
        }

        return empleado;
    }
    public static void MostrarEmpleadosPorCargo()
    {
        Console.Write("Ingrese la posición del empleado a buscar: ");
        string posicion = Console.ReadLine();
        var empleados = ListaEmpleados.Where(e => e.Posicion == posicion).ToList();

        Console.WriteLine("Empleados con la posición " + posicion + ":");
        foreach (var empleado in empleados)
        {
            empleado.MostrarInformacion();
        }
    }
}
