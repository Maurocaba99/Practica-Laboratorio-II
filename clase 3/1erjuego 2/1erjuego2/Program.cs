using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erjuego2
{
    // Lanzar dos dados seguidos
    
    public class Juego01e
    {
        public static void Main()
        {
            Random dado = new Random();
            int aleatorio1 = dado.Next(1, 11);
            int aleatorio2 = dado.Next(11, 21);
            Console.WriteLine("El numero del 1º dado es {0}", aleatorio1);
            Console.WriteLine("El numero del 2º dado es {0}", aleatorio2);
            int numero;
            Random r = new Random();
            int aleatorio = r.Next(1, 7);
            Console.WriteLine("Indica el numero que creas entre el 1 al 7: "); 
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == aleatorio)
                Console.WriteLine("Correcto, has acertado el numero");
            else
            {
                
                if (numero < aleatorio)
                    Console.WriteLine("Prueba un numero mas alto"); 
                if (numero > aleatorio)
                    Console.WriteLine("Prueba un numero mas bajo");
                
                Console.WriteLine("Indica el numero que creas: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if  (numero == aleatorio)
                    Console.WriteLine("Correcto, has acertado el numero");


                else
                    Console.WriteLine("No has acertado, era {0}", aleatorio);
            }


            Console.ReadKey();
        }
    }

}
