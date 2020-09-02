using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Pag192
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            int i;
            string valor = "";

            double promedio = 0.0;
            double suma = 0.0;

            double max = 0.0;
            double min = 10.0;

            Console.WriteLine("Ingrese la cantidad de alumnos a continuacion: ");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            double[] calif = new double[cantidad];

            for (i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese la calificacion del alumno " + (i+1) + ": ");
                valor = Console.ReadLine();
                calif[i] = Convert.ToDouble(valor);
            }

            for (i = 0; i < cantidad; i++)
            {
                suma += calif[i];
            }

            promedio = suma / cantidad;

            for (i = 0; i < cantidad; i++)
            {
                if (calif[i] < min)
                    min = calif[i];

                if (calif[i] > max)
                    max = calif[i];
            }

            Console.WriteLine("El promedio de calificaciones es: {0}", promedio);
            Console.WriteLine("La calificacion mas alta es: {0}", max);
            Console.WriteLine("La calificacion mas baja es: {0}", min);
            Console.ReadKey();
        }
    }
}
