using System;

namespace _1er_juego
{
   public class program
    {
        static void Main()
        {
            // Milisegundos
            int miliseg = DateTime.Now.Millisecond; 
                    Console.WriteLine(miliseg);

            // Dado del 100 al 1
            int dado = miliseg % 100 + 1;

            Console.Write("El numero del dado es {0} ", dado);
            Console.ReadKey();
        }

        
    }

   

    
            
    }




