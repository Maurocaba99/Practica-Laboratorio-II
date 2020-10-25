using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Mauro", "Cabanay");
            Console.WriteLine("nombre: " + persona1.getNombre() + " y el apellido es " + persona1.getApellido());
            Console.Read();
        }
    }
}
