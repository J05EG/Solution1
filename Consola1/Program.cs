using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Controlador;

namespace Consola1
{
    class Program
    {
        public static bool Funciones;

        public static void Agregar()
        {
            string nombre;
            int rut;
            DateTime fechaNacimiento;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un nombre");
                nombre = Console.ReadLine();
                if (nombre == string.Empty)
                {
                    Console.WriteLine("por favor ingrese un nombre");
                }
            } while (nombre == string.Empty);

            do
            {
                Console.WriteLine("Ingrese rut");
            } while (!int.TryParse(Console.ReadLine(), out rut));

            do
            {
                Console.WriteLine("Ingrese fecha de nacimiento ej: 11-12-2020");
                DateTime.TryParse(Console.ReadLine(), out fechaNacimiento);

            } while (fechaNacimiento <= new DateTime(1900, 1, 1));

            Persona p = new Persona(nombre, rut, fechaNacimiento);
            ListaPersonas.AgregarPersona(p);

            Console.WriteLine("Persona agregada exitosamente!");

            Console.WriteLine("presione cualquier tecla para volver al menu principal.");
            Console.ReadKey();
            Funciones = true;
        }

        public static void EliminarPersona()
        {
            Console.Clear();
            int rut;

            do
            {
                Console.WriteLine("Ingrese rut a eliminar");
            } while (!int.TryParse(Console.ReadLine(), out rut));
            if (ListaPersonas.BuscarRut(rut) == null)
            {
                Console.WriteLine("Rut no encontrado");
            }
            else
            {
                Persona p = ListaPersonas.BuscarRut(rut);
                ListaPersonas.EliminarPersona(p);
                Console.WriteLine("persona se Elimino correctamente");
            }
        }

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("         ----------------------------");
                Console.WriteLine("         |        Ingrese opcion    |");
                Console.WriteLine("         |    1.- Agregar persona   |");
                Console.WriteLine("         |    2.- Eliminar persona  |");
                Console.WriteLine("         |    3.- Buscar por Rut    |");
                Console.WriteLine("         |    4.- Listar            |");
                Console.WriteLine("         |    5.- Modificar datos   |");
                Console.WriteLine("         |    6.- Salir             |");
                Console.WriteLine("         ----------------------------");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Agregar();
                        break;
                    case 2:
                        Eliminar();
                        break;
                    case 3:
                        BuscarRut();
                        break;
                    case 4:
                        Listar();
                        break;
                    case 5:
                        Modificar();
                        break;
                    case 6:
                        Environment.Exit(1);
                        break;
                }
            } while (Funciones == true);
        }
    }
}
