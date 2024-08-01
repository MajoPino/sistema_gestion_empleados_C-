using sistema_gestion_empleados.Models;

Empresa.AgregarEmpleado(new Empleado("Carlos", "Rodriguez", 44, "12312739", "Gerente Administrativo", 4200000));
Empresa.AgregarEmpleado(new Empleado("Sara", "Zuluaga", 40, "12312439", "Contadora", 2000000));
Empresa.AgregarEmpleado(new Empleado("Pedro", "Gómez", 34, "16312739", "Administrador de base de datos", 3400000));
Empresa.AgregarEmpleado(new Empleado("Lina", "Parra", 24, "12382739", "Recursos Humanos", 1800000));
Empresa.AgregarEmpleado(new Empleado("Sergio", "Salazar", 37, "12377739", "Técnico", 2200000));

void MenuOpciones()
{
    Styles.MenuOpciones();
}

void irMenu()
{
    Console.Write(@"
PRESIONE CUALQUIER TECLA PARA VOLVER AL MENU PRINCIPAL.");
    Console.ReadKey();
    Main();
}

void AgregarEmpleado()
{
    Styles.EncabezadoAgregarEmpleado();
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Styles.Divisor1();
    Console.Write("Apellido: ");
    string apellido = Console.ReadLine();
    Styles.Divisor1();
    Console.Write("Número de identificación: ");
    string numeroIdentificacion = Console.ReadLine();
    Styles.Divisor1();
    Console.Write("Edad: ");
    byte edad = Convert.ToByte(Console.ReadLine());
    Styles.Divisor1();
    Console.Write("Posición: ");
    string posicion = Console.ReadLine();
    Styles.Divisor1();
    Console.Write("Salario: ");
    double salario = Convert.ToDouble(Console.ReadLine());
    Styles.Divisor1();
    Empresa.AgregarEmpleado(new Empleado(nombre, apellido, edad, numeroIdentificacion, posicion, salario));
    Console.WriteLine("EMPLEADO AGREGADO CORRECTAMENTE!");
    irMenu();
}

void MostrarTodosLosEmpleados()
{
    Styles.EncabezadoMostrarTodosLosEmpleados();
    Empresa.MostrarTodosLosEmpleados();
}

void BuscarEmpleado()
{
    Empresa.BuscarEmpleado();
    irMenu();  
}

void EliminarEmpleado()
{
    MostrarTodosLosEmpleados();
    Empresa.EliminarEmpleado();
    irMenu();
}

void ActualizarEmpleado()
{
    MostrarTodosLosEmpleados();
    Empresa.ActualizarEmpleado();
    irMenu();
}

void MostrarEmpleadosPorCargo()
{
    Empresa.MostrarEmpleadosPorCargo();
    irMenu();
}

void Main()
{
    Console.Clear();
    MenuOpciones();
    Console.Write("POR FAVOR, INGRESE UNA OPCIÓN: ");
    byte opcion = Convert.ToByte(Console.ReadLine());
    switch (opcion)
    {
        case 1:
        Console.Clear();
        AgregarEmpleado();
        break;

        case 2:
        Console.Clear();
        MostrarTodosLosEmpleados();
        irMenu();
        break;

        case 3:
        Console.Clear();
        BuscarEmpleado();
        break;

        case 4:
        Console.Clear();
        EliminarEmpleado();
        break;

        case 5:
        Console.Clear();
        ActualizarEmpleado();
        break;

        case 6:
        Console.Clear();
        MostrarEmpleadosPorCargo();
        break;

        case 0:
        Console.Clear();
        Console.WriteLine("GRACIAS POR USAR EL SISTEMA DE GESTIÓN DE EMPLEADOS!");
        Environment.Exit(0);
        break;

        default:
        Main();
        break;
    }

}

Main();