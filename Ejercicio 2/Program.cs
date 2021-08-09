using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DibujarCuadrado3x3();
        }
        public static void DibujarCuadrado3x3()
        {
            int i;
            int f;
            for (i = 0; i <= (3-1); i++)
            {
                for (f = 0; f <= (3-1); f++)
                {
                    Console.Write("*");
                    Console.Write(" ");

                }
                Console.WriteLine("");
            }
        }
    }
}
