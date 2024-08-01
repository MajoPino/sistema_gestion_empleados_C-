using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_gestion_empleados.Models;

    public class Styles
    {
        public static void MenuOpciones()
        {

            Console.WriteLine(@$"
----------------------------------------------------------------
|     BIENVENID@ AL SISTEMA DE GESTIÓN DE EMPLEADOS DE RIWI    |
................................................................
¦ OPCIONES DEL PROGRAMA:                                       ¦
¦ 1. AGREGAR EMPLEADO                                          ¦
¦ 2. MOSTRAR TODOS LOS EMPLEADOS                               ¦
¦ 3. BUSCAR EMPLEADO                                           ¦
¦ 4. ELIMINAR EMPLEADO                                         ¦
¦ 5. ACTUALIZAR EMPLEADO                                       ¦
¦ 6. MOSTRAR EMPLEADOS POR CARGO                               ¦
¦ 0. SALIR                                                     ¦
................................................................");
        }

        public static void EncabezadoAgregarEmpleado()
        {
            Console.WriteLine(@$"
----------------------------------------------------------------
|              AGREGAR NUEVO EMPLEADO A LA EMPRESA             |
----------------------------------------------------------------");
        }

        public static void Divisor1()
        {
            Console.WriteLine("----------------------------------------------------------------");
        }

        public static void EncabezadoMostrarTodosLosEmpleados()
        {
            Console.WriteLine(@$"
--------------------------------------------------------------------------------------------------------------
|                                         EMPLEADOS DE LA EMPRESA                                            |
--------------------------------------------------------------------------------------------------------------
¦ NOMBRE COMPLETO      |  N° DOCUMENTO  |  EDAD   | SALARIO               | POSICIÓN                         ¦
..............................................................................................................");
        }

    }
