using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L8._1
{
    static class Printer
    {
        static public void Print(string pString, int color)
        {
            ConsoleColor fgColor = new ConsoleColor();
            switch(color)
            {
                case (int)Color.Blue:
                    {
                        fgColor = ConsoleColor.Blue;
                        break;
                    }
                case (int)Color.Green:
                    {
                        fgColor = ConsoleColor.Green;
                        break;
                    }
                case (int)Color.Red:
                    {
                        fgColor = ConsoleColor.Red;
                        break;
                    }
                default:
                    {
                        fgColor = ConsoleColor.Gray;
                        break;
                    }
            }
            Console.ForegroundColor = fgColor;
            Console.WriteLine(pString);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
