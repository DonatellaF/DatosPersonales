using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPersonalesApp
{
    public class PersonaService
    {/// <summary>
    /// Devuelve una persona con nombre y apellido.
    /// </summary>
    /// <returns></returns>
        public Persona GetDatosPersonales()
        {
            //TODO apellido nulo, nombre nulo.
            //TODO solo letras.
            var persona = new Persona();
            Console.WriteLine("Ingrese los siguientes datos personales:");
            Console.WriteLine("Nombre:");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido:");
            persona.Apellido = Console.ReadLine();
            return persona;
        }
        /// <summary>
        /// solicita por consola una fecha, si es valida la devuelve y sino lanza una excepcion.
        /// </summary>
        /// <returns></returns>
        public DateTime GetFechaNacimiento()
        {
            //TODO controlar que sea mayor de edad.
            string fecha;
            DateTime fechaNacimiento;
            do
            {
                Console.WriteLine("Ingrese su fecha de nacimiento: dd/mm/aaaa");
                fecha = Console.ReadLine();
            }
            while (!DateTime.TryParse(fecha, out fechaNacimiento) && Continuar());
            return fechaNacimiento;
        }
        /// <summary>
        /// Si la respuesta es s o S, devuelve true.
        /// </summary>
        /// <returns></returns>
        private bool Continuar()
        {
            Console.WriteLine("¿Desea volver a intentarlo? Presione s si desea volver a intentarlo, de lo contrario presione n");
            string respuesta = Console.ReadLine().ToUpper();

            return respuesta == "S";
        }
    }
}
