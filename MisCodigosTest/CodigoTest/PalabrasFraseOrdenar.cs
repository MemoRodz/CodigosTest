using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisCodigosTest.CodigoTest
{
    public class PalabrasFraseOrdenar
    {

        public static void PalabrasOrdenar()
        {

            try
            {
                Console.WriteLine("Ingrese una frase:");
                string? frase = Console.ReadLine();
                if (!string.IsNullOrEmpty(frase) || !string.IsNullOrWhiteSpace(frase))
                {
                    // Dividir la frase en palabras
                    string[] palabras = frase.Split(' ');

            Console.WriteLine("Ingrese una frase:");
            string? frase = Console.ReadLine();


                    // Ordenar las palabras alfabéticamente
                    Array.Sort(palabras);

                    // Unir las palabras para formar la frase ordenada
                    string fraseOrdenada = string.Join(" ", palabras);

                    // Mostrar la frase ordenada
                    Console.WriteLine("Frase ordenada: " + fraseOrdenada);
                }
                else Console.WriteLine("No hay frase para ordenar.");


            }
            catch (Exception)
            {
                Console.WriteLine("No hay palabras para ordenar.");
            }

            // Mostrar la frase ordenada
            Console.WriteLine("Frase ordenada: " + fraseOrdenada);

            Console.WriteLine("\nMenú principal...");

        }
        /*
         using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una frase:");
        string frase = Console.ReadLine();

        // Dividir la frase en palabras
        string[] palabras = frase.Split(' ');

        // Ordenar las palabras alfabéticamente
        Array.Sort(palabras);

        // Unir las palabras para formar la frase ordenada
        string fraseOrdenada = string.Join(" ", palabras);

        // Mostrar la frase ordenada
        Console.WriteLine("Frase ordenada: " + fraseOrdenada);

        Console.ReadLine();
    }
}
         */
    }
}
