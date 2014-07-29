using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L8._1
{
    static class Printer
    {
        static public void Print(string pString, string color)
        {
            Color colorValue;           
            if (Enum.TryParse(color, true, out colorValue))
            {
                Console.ForegroundColor = colorValue.ToConsoleColor();
                Console.WriteLine(pString);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine("{0} is not a member of the Color enumeration.", color);
            }   
        }

    }
}
