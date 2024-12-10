using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisCodigosTest.CodigoTest
{
    public class Fibonacci
    {

        public static void NumFib()
        {

            Console.WriteLine("Hasta que número Fibonacci deseas:");
            string? entrada = Console.ReadLine();
            int n = 0;

            if (!int.TryParse(entrada, out n))
            {
                n = 7;
                Console.WriteLine($"No fue un número entero, se usará el valor establecido: {n}");
            }

            Console.WriteLine("Los primeros " + n + " números de la secuencia de Fibonacci son:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(FibonacciR(i));

                Console.WriteLine("Hasta que número Fibonacci deseas ('S' para salir):");

                if (string.IsNullOrEmpty(entrada) || string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("No se aceptan espacios en blanco o vacíos.");
                    return;
                }
                if (entrada == "s")
                {
                    Console.WriteLine("\nRegresando al menú.\nPresiona cualquier tecla.");
                    Console.ReadKey();
                    return;
                }
                if (int.TryParse(entrada, out n))
                {
                    Console.WriteLine("Los primeros " + n + " números de la secuencia de Fibonacci son:");

                    for (int fib = 0; fib < n; fib++)
                    {
                        Console.WriteLine(FibonacciR(fib));
                    }
                    Console.WriteLine("\nMenú principal...");

                }
                else Console.WriteLine("No es un entero.\nRegresando.");

            }
        }

        private static int FibonacciR(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibonacciR(n - 1) + FibonacciR(n - 2);
            }
        }


        //using System;

        //class Program
        //    {
        //        static void Main(string[] args)
        //        {
        //            Console.WriteLine("Hasta que número Fibonacci deseas:");
        //            int n = Convert.ToInt32(Console.ReadLine());

        //            Console.WriteLine("Los primeros " + n + " números de la secuencia de Fibonacci son:");

        //            for (int i = 0; i < n; i++)
        //            {
        //                Console.WriteLine(Fibonacci(i));
        //            }

        //            Console.ReadLine();
        //        }

        //        static int Fibonacci(int n)
        //        {
        //            if (n <= 1)
        //            {
        //                return n;
        //            }
        //            else
        //            {
        //                return Fibonacci(n - 1) + Fibonacci(n - 2);
        //            }
        //        }
        //    }




    }
}
