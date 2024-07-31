using sistema_gestion_empleados.Models;



Empresa.AgregarEmpleado(new Empleado("Carlos", "Rodriguez", "12312739", 44, "Gerente Administrativo", 4200000));
Empresa.AgregarEmpleado(new Empleado("Sara", "Zuluaga", "12312439", 40, "Contadora", 2000000));
Empresa.AgregarEmpleado(new Empleado("Pedro", "Gómez", "16312739", 34, "Administrador de base de datos", 3400000));
Empresa.AgregarEmpleado(new Empleado("Lina", "Parra", "12382739", 24, "Recursos Humanos", 1800000));
Empresa.AgregarEmpleado(new Empleado("Sergio", "Salazar", "12377739", 37, "Técnico", 2200000));

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
    Empresa.AgregarEmpleado(new Empleado(nombre, apellido, numeroIdentificacion, edad, posicion, salario))
    Console.WriteLine("Empleado agregado correctamente!");
}