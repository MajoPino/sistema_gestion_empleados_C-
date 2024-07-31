using sistema_gestion_empleados.Models;



Empresa.AgregarEmpleado(new Empleado("Carlos", "Rodriguez", "12312739", 44, "Gerente Administrativo", 4200000));
Empresa.AgregarEmpleado(new Empleado("Sara", "Zuluaga", "12312439", 40, "Contadora", 2000000));
Empresa.AgregarEmpleado(new Empleado("Pedro", "Gómez", "16312739", 34, "Administrador de base de datos", 3400000));
Empresa.AgregarEmpleado(new Empleado("Lina", "Parra", "12382739", 24, "Recursos Humanos", 1800000));
Empresa.AgregarEmpleado(new Empleado("Sergio", "Salazar", "12377739", 37, "Técnico", 2200000));

void irMenu()
{
    Console.Write(@"
Presione cualquier tecla para volver al menú principal.");
    Console.ReadKey();
    Main();
}

void AgregarEmpleado()
{
    Console.WriteLine("Agregar un nuevo empleado");
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Apellido: ");
    string apellido = Console.ReadLine();
    Console.Write("Número de identificación: ");
    string numeroIdentificacion = Console.ReadLine();
    Console.Write("Edad: ");
    byte edad = Convert.ToByte(Console.ReadLine());
    Console.Write("Posición: ");
    string posicion = Console.ReadLine();
    Console.Write("Salario: ");
    double salario = Convert.ToDouble(Console.ReadLine());
    Empresa.AgregarEmpleado(new Empleado(nombre, apellido, numeroIdentificacion, edad, posicion, salario));
    Console.WriteLine("Empleado agregado correctamente!");
    irMenu();
}

void MostrarTodosLosEmpleados()
{
    Empresa.MostrarTodosLosEmpleados();
}

void BuscarEmpleado()
{
    MostrarTodosLosEmpleados();
    Empresa.BuscarEmpleado();
    irMenu();  
}

void EliminarEmpleado()
{
    BuscarEmpleado();
    Empresa.EliminarEmpleado();
    irMenu();
}

void Main()
{
    Console.Clear();
    Console.WriteLine("Menú principal");
    Console.WriteLine(@$"
1. Agregar Empleado
2. Mostrar Todos Los Empleados
3. Buscar Empleado
4. Eliminar Empleado
0. Salir");
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

        case 0:
        Console.Clear();
        Console.WriteLine("Gracias por usar el sistema de gestión de empleados!");
        Environment.Exit(0);
        break;

        default:
        Main();
        break;
    }

}

Main();