using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisCodigosTest.CodigoTest
{
    public class TempConvert
    {
        static decimal celsiusF(decimal fahrenheit)
        {
            return (fahrenheit - 32m) * (5m / 9m);
        }

        static decimal fahrenheit(decimal celsius)
        {
            return celsius * 9 / 5 + 32;
        }
    }
}
