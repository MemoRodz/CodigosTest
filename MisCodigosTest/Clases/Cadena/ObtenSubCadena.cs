using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisCodigosTest.Clases.Cadena
{
    internal class ObtenSubCadena
    {
        public static string Obten()
        {
            string cadena = "{Token=8C037B9F-0966-4950-8399-DBA965368FA8&sNombre=YOLO&sUsuario=YPEREZ}";
            int posicionNombre = cadena.IndexOf("sNombre=") + "sNombre=".Length;
            int posicionUsuario = cadena.IndexOf("&sUsuario=");
            int posicionFinal = posicionUsuario - posicionNombre;
            try
            {
                Console.WriteLine($"\nCadena establecida: {cadena}");
                Console.WriteLine($"Posición inicial: {posicionNombre}");
                Console.WriteLine($"Posición final: {posicionUsuario}");
                Console.WriteLine($"Largo de subcadena: {posicionFinal}");

                string subcadenaNombre = cadena.Substring(posicionNombre, posicionFinal);
                return subcadenaNombre;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            
        }








    }
}
