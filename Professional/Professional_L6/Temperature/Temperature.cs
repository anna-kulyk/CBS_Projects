using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    static class Temperature
    {
        public static decimal ConvertToFahrenheit(decimal temperature)
        {
            return temperature * 9 / 5 + 32;
        }
    }
}
