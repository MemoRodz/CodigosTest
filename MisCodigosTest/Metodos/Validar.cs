using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MisCodigosTest.Metodos
{
    public class Validar
    {
        /// <summary>
        /// Valida RFC Mexicano con formato de fecha.
        /// </summary>
        /// <param name="RFC">RFC</param>
        /// <returns>Verdadero si válido.</returns>
        public static Boolean ValidaRFC(string? RFC)
        {
            if (string.IsNullOrWhiteSpace(RFC) || string.IsNullOrEmpty(RFC))
            {
                return false;
            }

            Regex rx = new Regex(@"^[A-Z,Ñ,&amp;]{3,4}[0-9]{2}[0-1][0-9][0-3][0-9][A-Z,0-9]?[A-Z,0-9]?[0-9,A-Z]?$");

            return rx.Match(RFC).Success;
        }
    }
}
