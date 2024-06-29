using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisCodigosTest.CodigoTest
{
    public class Primos
    {

        public static void primosRango()
        {
            Console.WriteLine("Ingrese el número inicial del rango:");
            int inicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número final del rango:");
            int fin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los números primos en el rango de {0} a {1} son:", inicio, fin);

            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nMenú principal...");
        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        /*

        using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el número inicial del rango:");
        int inicio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el número final del rango:");
        int fin = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Los números primos en el rango de {0} a {1} son:", inicio, fin);

        for (int i = inicio; i <= fin; i++)
        {
            if (EsPrimo(i))
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}


        */
    }
}
