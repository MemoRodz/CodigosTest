using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisCodigosTest.CodigoTest
{
    public class TempConvert
    {
        /// <summary>
        /// Conversión de Grados Fahrenheit a Celsius 
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns>Grados Celsius</returns>
        public static decimal celsiusF(decimal fahrenheit)
        {
            return (fahrenheit - 32m) * (5m / 9m);
        }
        /// <summary>
        /// Conversión de Grados Celsius a Fahrenheit.
        /// </summary>
        /// <param name="celsius">Grados Celsius.</param>
        /// <returns>Grados Fahrenheit.</returns>
        public static decimal fahrenheit(decimal celsius)
        {
            return celsius * 9 / 5 + 32;
        }
    }
}
