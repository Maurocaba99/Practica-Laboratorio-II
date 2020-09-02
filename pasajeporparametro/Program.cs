using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    class Program
    {
        static void Main(string[] ) { 
  
                //Le pasamos el parametro a la funcion saludar() para que nos muestre en pantalla el mensaje de saludo.
                saludar("Jesus");

                //La funcion suma nos devuelve un valor, por lo tanto este valor lo guardamos en la variable resultado para poder mostrarlo.
                int resultado = suma(2, 5);
                Console.WriteLine("Suma = " + resultado);
                //Otra forma de mostrarlo sin tener que generar una nueva variable es la siguiente:
                Console.WriteLine("Suma = " + suma(3, 6));

                int n = 5;
                //Pasamos el parametro por valor a la funcion.
                duplicarPorValor(n);
                Console.WriteLine("Referencia pasada por valor: " + n);

                //Pasamos el parametro por referencia a la funcion.
                duplicarPorReferencia(ref n);
                Console.WriteLine("Referencia pasada por referencia: " + n);
            }

            public static void saludar(string nombre)
            {
                Console.WriteLine("Hola {0}!", nombre);
            }

            public static int suma(int num1, int num2)
            {
                int resultado = num1 + num2;

                return resultado;
            }

            /*Parametro pasado por valor: si efectuamos un cambio dentro de la funcion este no se guarda.
                                       (se hace una copia de la variable y se trabaja con la copia).*/
            public static void duplicarPorValor(int num)
            {
                num = num * 2;
            }
            /*Parametro pasado por referencia: si hacemos un cambio del parametro dentro de la funcion este va a conservar los cambios.
                                       (se trae la variable original y se trabaja con ella).*/
            public static void duplicarPorReferencia(ref int num)
            {
                num = num * 2;
              Console.ReadKey();
            }

        }
    }


