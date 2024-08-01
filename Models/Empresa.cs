using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_gestion_empleados.Models;

public class Empresa : Empleado
{
    public static string NombreEmpresa { get; set; }
    public static string Direccion { get; set; }
    public static List<Empleado> ListaEmpleados = new List<Empleado>();
    public static List<Cliente> ListaClientes = new List<Cliente>();

    public Empresa(string nombre, string apellido, int edad, string numeroIdentificacion, string posicion, double salario, string nombreEmpresa, string direccion) : base(nombre, apellido, edad, numeroIdentificacion, posicion, salario)
    {
        NombreEmpresa = nombreEmpresa.Trim();
        Direccion = direccion.Trim();
    }

    public static void AgregarCliente(Cliente cliente)
    {
        ListaClientes.Add(cliente);
    }

    public static void EliminarCliente()
    {
        Console.Write("POR FAVOR, INGRESE EL EMAIL DEL CLIENTE A ELIMINAR: ");
        string email = Console.ReadLine().ToLower();
        Cliente cliente = ListaClientes.FirstOrDefault(c => c.Email == email);

        if (cliente!= null)
        {
            ListaClientes.Remove(cliente);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("CLIENTE ELIMINADO CORRECTAMENTE!");
        }
        else
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("NO SE ENCONTRÓ EL CLIENTE, POR FAVOR VERIFIQUE LA INFORMACIÓN E INTENTE DE NUEVO.");
        }
    }
    public static void MostrarTodosLosClientes()
    {
        foreach (Cliente cliente in ListaClientes)
        {
            cliente.MostrarInformacion();
        }
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
    }

    public static void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
    }

    public static void EliminarEmpleado()
    {
        Console.Write(@$"
POR FAVOR, INGRESE EL NOMBRE DEL EMPLEADO A ELIMINAR: ");
        string nombre = Console.ReadLine();
        Console.Write(@$"

POR FAVOR, INGRESE EL APELLIDO DEL EMPLEADO A ELIMINAR: ");
        string apellido = Console.ReadLine();
        Empleado empleado = ListaEmpleados.FirstOrDefault(e => e.Nombre == nombre && e.Apellido == apellido);

        if (empleado != null)
        {
            ListaEmpleados.Remove(empleado);
            Console.WriteLine(@$"
------------------------------------------------------------------------------------------------");
            Console.WriteLine("EMPLEADO ELIMINADO CORRECTAMENTE!");
        }
        else
        {
            Console.WriteLine(@$"
------------------------------------------------------------------------------------------------");
            Console.WriteLine(@$"NO SE ENCONTRÓ EL EMPLEADO, POR FAVOR VERIFIQUE LA INFORMACIÓN E INTENTE DE NUEVO.");
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
        Console.Write("INGRESE EL NÚMERO DE IDENTIFICACIÓN DEL EMPLEADO A ACTUALIZAR: ");
        string numeroIdentificacion = Console.ReadLine();
        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroIdentificacion == numeroIdentificacion);
        if (empleado != null)
        {
            Console.Clear();
            Console.WriteLine(@$"
----------------------------------------------------------------
|                       EDITAR EMPLEADO                        |
----------------------------------------------------------------");
            Console.Write("Nuevo Nombre: ");
            string Nombre = Console.ReadLine();
            empleado.Nombre = Nombre;
            Console.WriteLine(@$"----------------------------------------------------------------");
            Console.Write("Nuevo Apellido: ");
            string Apellido = Console.ReadLine();
            empleado.Apellido = Apellido;
            Console.WriteLine(@$"----------------------------------------------------------------");
            Console.Write("Nueva Edad: ");
            int Edad = Convert.ToInt32(Console.ReadLine());
            empleado.Edad = Edad;
            Console.WriteLine(@$"----------------------------------------------------------------");
            Console.Write("Nueva Posición: ");
            string Posicion = Console.ReadLine();
            empleado.Posicion = Posicion;
            Console.WriteLine(@$"----------------------------------------------------------------");
            Console.Write("Nuevo Salario: ");
            double Salario = Convert.ToDouble(Console.ReadLine());
            empleado.Salario = Salario;
            Console.WriteLine(@$"----------------------------------------------------------------");
            Console.WriteLine("EMPLEADO ACTUALIZADO CORRECTAMENTE!");
        }
        else
        {
            Console.WriteLine(@$"
------------------------------------------------------------------------------------------------");
            Console.WriteLine(@$"NO SE ENCONTRÓ EL EMPLEADO, POR FAVOR VERIFIQUE LA INFORMACIÓN E INTENTE DE NUEVO.");
        }
    }

    public static void BuscarEmpleado()
    {
        Console.Write("POR FAVOR, INGRESE EL NÚMERO DE IDENTIFICACIÓN DEL EMPLEADO A BUSCAR: ");
        string numeroIdentificacion = Console.ReadLine();
        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroIdentificacion == numeroIdentificacion);
        if (empleado != null)
        {
            Console.WriteLine(@$"
--------------------------------------------------------------------------------------------------------------
|                                            DATOS DEL EMPLEADO                                              |
--------------------------------------------------------------------------------------------------------------
¦ NOMBRE COMPLETO      |  N° DOCUMENTO  |  EDAD   | SALARIO               | POSICIÓN                         ¦
..............................................................................................................");
            empleado.MostrarInformacion();
        }
        else
        {
            Console.WriteLine(@$"
------------------------------------------------------------------------------------------------");
            Console.WriteLine(@$"NO SE ENCONTRÓ EL EMPLEADO, POR FAVOR VERIFIQUE LA INFORMACIÓN E INTENTE DE NUEVO.");
        }

    }
    public static void MostrarEmpleadosPorCargo()
    {
        Console.Write("INGRESE LA POSICIÓN DEL EMPLEADO A BUSCAR: ");
        string posicion = Console.ReadLine();
        var empleados = ListaEmpleados.Where(e => e.Posicion == posicion).ToList();

        string posicionUppercase = posicion.ToUpper();

        if (empleados.Count == 0)
        {
            Console.WriteLine(@$"
------------------------------------------------------------------------------------------------");
            Console.WriteLine(@$"NO SE ENCONTRÓ NINGÚN EMPLEADO CON LA POSICIÓN {posicionUppercase}. POR FAVOR, VERIFIQUE LA INFORMACIÓN E INTENTE DE NUEVO.");
        }
        else
        {
            Console.WriteLine(@$"
--------------------------------------------------------------------------------------------------------------
|                                         EMPLEADOS DE LA EMPRESA                                            |
--------------------------------------------------------------------------------------------------------------
¦ NOMBRE COMPLETO      |  N° DOCUMENTO  |  EDAD   | SALARIO               | POSICIÓN                         ¦
..............................................................................................................");
        foreach (var empleado in empleados)
        {
            empleado.MostrarInformacion();
        }
        }
    }
}
