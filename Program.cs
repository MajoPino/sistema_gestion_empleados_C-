using sistema_gestion_empleados.Models;

Empresa.AgregarEmpleado(new Empleado("Carlos", "Rodriguez", 44, "12312739", "Gerente Administrativo", 4200000));
Empresa.AgregarEmpleado(new Empleado("Sara", "Zuluaga", 40, "12312439", "Contadora", 2000000));
Empresa.AgregarEmpleado(new Empleado("Pedro", "Gómez", 34, "16312739", "Administrador de base de datos", 3400000));
Empresa.AgregarEmpleado(new Empleado("Lina", "Parra", 24, "12382739", "Recursos Humanos", 1800000));
Empresa.AgregarEmpleado(new Empleado("Sergio", "Salazar", 37, "12377739", "Técnico", 2200000));

Empresa.AgregarCliente(new Cliente("Leo", "Torres", 22, "leotorres@gmail.com", "3242637842"));
Empresa.AgregarCliente(new Cliente("Juana", "Cardona", 23, "juanacar22@gmail.com", "3242633844"));
Empresa.AgregarCliente(new Cliente("Santiago", "Iglesias", 19, "santiiglesias@gmail.com", "3242637942"));
Empresa.AgregarCliente(new Cliente("Fernando", "López", 45, "fercho@gmail.com", "3242137842"));
Empresa.AgregarCliente(new Cliente("Catalina", "Medina", 30, "catalinamed@gmail.com", "3242557845"));

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

void AgregarCliente()
{
    Styles.EncabezadoAgregarCliente();
    Console.Write("Nombre del cliente: ");
    string nombre = Console.ReadLine();
    Styles.Divisor1();
    Console.Write("Apellido del cliente: ");
    string apellido = Console.ReadLine();
    Styles.Divisor1();
    Console.Write("Edad del cliente: ");
    int edad = Convert.ToInt32(Console.ReadLine());
    Styles.Divisor1();
    Console.Write("Email del cliente: ");
    string email = Console.ReadLine();
    Styles.Divisor1();
    Console.Write("Número telefónico del cliente: ");
    string telefono = Console.ReadLine();
    Styles.Divisor1();
    Empresa.AgregarCliente(new Cliente(nombre, apellido, edad, email, telefono));
    Console.WriteLine("CLIENTE AGREGADO CORRECTAMENTE!");
    irMenu();
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
    int edad = Convert.ToInt32(Console.ReadLine());
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

void MostrarTodosLosClientes()
{
    Styles.EncabezadoMostrarTodosLosClientes();
    Empresa.MostrarTodosLosClientes();
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

void EliminarCliente()
{
    MostrarTodosLosClientes();
    Empresa.EliminarCliente();
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
        
        case 7:
        Console.Clear();
        AgregarCliente();
        break;

        case 8:
        Console.Clear();
        MostrarTodosLosClientes();
        irMenu();
        break;
        
        case 9:
        Console.Clear();
        EliminarCliente();
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