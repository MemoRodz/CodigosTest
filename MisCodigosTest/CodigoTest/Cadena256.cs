using CodigosTest.BLL.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigosTest.BLL.Implementacion;

namespace MisCodigosTest.CodigoTest
{
    public class Cadena256
    {

        public static void convertirCadenaSHA256()
        {
            Console.WriteLine(@"Cifrado SHA256.
    Elige una opción:
        a) Crear Cadena Cifrada.
        b) Cifrar cadena.
        r) Regresar.
");
            string? metodo = Console.ReadLine();
            if (!string.IsNullOrEmpty(metodo) || !string.IsNullOrWhiteSpace(metodo))
            {
                switch (metodo)
                {
                    case "a":
                        Console.WriteLine("Dame una cadena:");
                        string? entrada = Console.ReadLine();
                        if (!string.IsNullOrEmpty(entrada) || !string.IsNullOrWhiteSpace(entrada))
                        {
                            Console.WriteLine($"Cadena cifrada SHA256:\n{cifrarCadena(entrada)}");
                        }
                        else Console.WriteLine("No se aceptan cadenas vacías, nulas o espacios en blanco.");

                        Console.WriteLine("\nMenú principal...");
                        break;
                    case "b":
                        Console.WriteLine($"Nueva cadena SHA256:\n{CCCSHA256()}");
                        Console.WriteLine("\nMenú principal...");
                        break;
                    case "r":
                        Console.WriteLine("Regresando al menú...\n");
                        Console.WriteLine("Presiona cualquier tecla.");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Debió ser una opción válida.\nRegresando al menú.");
            }
            return;
        }

        /// <summary>
        /// Cifrar cadena en SHA256.
        /// </summary>
        /// <param name="cadena">Cadena a cifrar.</param>
        /// <returns>Cadena cifrada.</returns>
        public static string cifrarCadena(string cadena)
        {
            string cadena256 = cadena;
            UtilidadesService util = new UtilidadesService();

            if (!string.IsNullOrEmpty(cadena) || !string.IsNullOrWhiteSpace(cadena))
            {
                cadena256 = util.ConvertirSha256(cadena);
            }

            return cadena256;
        }
        /// <summary>
        /// Crea Cadena Cifrada SHA256.
        /// </summary>
        /// <returns>Cadena cifrada.</returns>
        public static string CCCSHA256()
        {
            UtilidadesService util = new UtilidadesService();
            string cadenaGenerada = util.GenerarClave();
            string cadena256 = util.ConvertirSha256(cadenaGenerada);

            return cadena256;
        }
    }
}
