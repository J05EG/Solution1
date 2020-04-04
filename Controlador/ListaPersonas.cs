using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class ListaPersonas
    {
        private static List<Persona> lista = new List<Persona>();

        public static bool AgregarPersona(Persona p)
        {
            try
            {
                lista.Add(p);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EliminarPersona(Persona p)
        {
            try
            {
                lista.Remove(p);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Persona BuscarRut(int rut)
        {
            foreach (Persona x in lista)
            {
                if (x.Rut == rut)
                {
                    return x;
                }
            }

            return null;
        }

        public static Persona Listar()
        {
            foreach (Persona p in lista)
            {
                Console.WriteLine("---" + p.Nombre + "---" + p.Rut + "---" + p.FechaNacimiento);
            }

            return null;
        }

    }
}
