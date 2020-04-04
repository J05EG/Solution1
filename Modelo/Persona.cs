using System;

namespace Modelo
{
    public class Persona
    {
        #region Campos de objeto
        private string nombre;
        private int rut;
        private DateTime fechaNacimiento;
        #endregion

        #region Propiedades
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set
            {
                if (value > new DateTime(1900, 1, 1))
                {
                    fechaNacimiento = value;
                }
                else
                {
                    throw new Exception("La edad no puede ser igual o inferior a 1 de enero de 1900");
                }
            }
        }
        
        public int Rut
        {
            get { return rut; }
            set {
                if (value >= 0)
                {
                    rut = value;
                }
                else
                {
                    throw new Exception("El rut debe ser mayor a 0");
                }
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set {
                if(value != string.Empty)
                {
                    nombre = value;
                }
                else
                {
                    throw new Exception("No se puede ingresar un nombre vacio");
                }
            }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor con parámetros de clase Persona.
        /// </summary>
        /// <param name="nombre">Valor de cadena de caracteres que representa el nombre
        /// de la persona.</param>
        /// <param name="rut">Calor entero que represnta la edad de la persona.</param>
        /// <param name="fechaNacimiento">Valor DateTime que indica la fecha de nacimiento.</param>
        public Persona(string nombre, int rut, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Rut = rut;
            FechaNacimiento = fechaNacimiento;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método que permite saludar a la persona.
        /// </summary>
        /// <returns>Cadena de caracteres que saludan.</returns>
        public string Saludar()
        {
            return string.Format("Hola mi nombre es {0}, mi rut es {1} y mi fecha de nacimiento es: {2}",
                nombre, rut, fechaNacimiento);
        }

        

        #endregion
    }
}
