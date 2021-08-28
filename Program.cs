using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPersonalesApp
{
    public class Program
    {
        public static void Main()
        {
            var personaService = new PersonaService();

            
            Persona persona = personaService.GetDatosPersonales();
            Console.WriteLine($"Bienvenido {persona.Nombre}");

            persona.FechaNaciciento = personaService.GetFechaNacimiento();
            Console.ReadLine();
        }
    }
}
