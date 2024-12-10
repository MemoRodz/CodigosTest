using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversiones;

namespace MisCodigosTest.CodigoTest
{
    public class CantConversion
    {
        public static void Inicio()
        {
            double Cantidad = 0;
            string ConvertCant = string.Empty;

            try
            {
                Console.WriteLine("Escribe el número a convertir a pesos mexicanos: ");
                Cantidad = double.Parse(Console.ReadLine());
                Console.Clear();
                ConvertCant = Conversion.CONVERTIRNUM(Cantidad, false);
                Console.WriteLine($"Cantidad en número: {Cantidad.ToString()}\nCantidad en letra:\n{ConvertCant}\n");
                Console.WriteLine("\tGracias por compartir el código de conversión a:\t http://exceltotal.com/ \t...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la conversión.\n{ex.Message}");
            }
        }
    }
}
