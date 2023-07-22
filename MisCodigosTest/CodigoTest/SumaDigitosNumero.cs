using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisCodigosTest.CodigoTest
{
    public class SumaDigitosNumero
    {
        public static void numeros()
        {
            Console.WriteLine("Ingrese un número entero:");
            int numero = int.Parse(Console.ReadLine());

            int sumaDigitos = CalcularSumaDigitos(numero);

            Console.WriteLine("La suma de los dígitos es: " + sumaDigitos);
        }

        static int CalcularSumaDigitos(int numero)
        {
            int suma = 0;

            while (numero != 0)
            {
                int digito = numero % 10;
                suma += digito;
                numero /= 10;
            }

            return suma;
        }

        /*
         using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero:");
        int numero = int.Parse(Console.ReadLine());

        int sumaDigitos = CalcularSumaDigitos(numero);

        Console.WriteLine("La suma de los dígitos es: " + sumaDigitos);

        Console.ReadLine();
    }

    static int CalcularSumaDigitos(int numero)
    {
        int suma = 0;

        while (numero != 0)
        {
            int digito = numero % 10;
            suma += digito;
            numero /= 10;
        }

        return suma;
    }

}
         */
    }
}
