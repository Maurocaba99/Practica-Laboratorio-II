// Primer mini-esqueleto de juego en modo texto
// Versión "g"

using System;

using System.Threading; // Para Thread.Sleep


public class JuegoArray
{
    public static void Main()
    {
        ConsoleKeyInfo tecla;
        int x = 40, y = 12;
        int xo1 = 20, yo1 = 15; // Obstáculo 1
        int xo2 = 25, yo2 = 5; // Obstáculo 2
        int xo3 = 62, yo3 = 21; // Obstáculo 3
        float xe1 = 10, ye1 = 10, incr1 = 0.5f; // Enemigo 1
        float xe2 = 20, ye2 = 20; incr1 = 0.5f; // enemigo 2
        float xe3 = 15, ye3 = 15; incr1 = 0.5f; // enemigo 3
        
        int fin = 0; // 0 = no terminado, 1 = terminado
        int[] xPremio = new int[10]; // Premios
        int[] yPremio = new int[10];
        // Genero las posiciones de los premios al azar
        Random generador = new Random();
        for (int i = 0; i < 10; i++)
        {
            xPremio[i] = generador.Next(0, 80);
            yPremio[i] = generador.Next(0, 24);
        }
        // Bucle de juego
        while (fin == 0)
        {
            // Dibujar
            Console.Clear();
            Console.SetCursorPosition(x, y);

            Console.Write("A");
            Console.SetCursorPosition(xo1, yo1); // Obstáculos
            Console.Write("o");

            Console.SetCursorPosition(xo2, yo2); Console.Write("o");

            Console.SetCursorPosition(xo3, yo3); Console.Write("o");

            Console.SetCursorPosition((int)xe1, (int)ye1);//enemigo 1
            Console.Write("@");
            Console.SetCursorPosition((int)xe2, (int)ye2);// Enemigo 2
            Console.Write("H");
            Console.SetCursorPosition((int)xe3, (int)ye3);//enemigo 3
            Console.Write("P");

            for (int i = 0; i < 10; i++) // Premios
            {
                Console.SetCursorPosition(xPremio[i], yPremio[i]); Console.Write("*");
            }
            // Leer teclas y calcular nueva posición
            if (Console.KeyAvailable)
            {
                tecla = Console.ReadKey(false);
                if (tecla.Key == ConsoleKey.RightArrow) x++;
                if (tecla.Key == ConsoleKey.LeftArrow) x--;
                if (tecla.Key == ConsoleKey.DownArrow) y++;
                if (tecla.Key == ConsoleKey.UpArrow) y--;
            }
            // Mover enemigos, entorno
            xe1 = xe1 + incr1;
            if ((xe1 == 0) || (xe1 == 79))
                incr1 = -incr1;
            //mover enemigos 2
            xe2 = xe2 + incr1;
            if ((xe2 == 0) || (xe2 == 79))
                incr1 = -incr1;
            //mover enemigos 3
            xe3 = xe3 + incr1;
            if ((xe3 == 0) || (xe3 == 79))
                incr1 = -incr1;
            // Colisiones, perder vidas, etc
            if (((x == xo1) && (y == yo1))
            || ((x == xo2) && (y == yo2))
            || ((x == xo3) && (y == yo3))
            )
                fin = 1;
            if (((x == xe1) && (y == ye1))
             || ((x == xe2) && (y == ye2))
             || ((x == xe3) && (y == ye3)))
                fin = 1;
          
            // Pausa hasta el siguiente "fotograma" del juego
            Thread.Sleep(40);
        }
    }
}
