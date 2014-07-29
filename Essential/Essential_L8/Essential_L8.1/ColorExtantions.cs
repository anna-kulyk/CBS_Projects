using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L8._1
{
    static class ColorExtantions
    {
        static public ConsoleColor ToConsoleColor(this Color color)
        {
            ConsoleColor cc = new ConsoleColor();
            switch (color)
            {
                case Color.Blue:
                    {
                        cc = ConsoleColor.Blue;
                        break;
                    }
                case Color.Green:
                    {
                        cc = ConsoleColor.Green;
                        break;
                    }
                case Color.Red:
                    {
                        cc = ConsoleColor.Red;
                        break;
                    }
                default:
                    {
                        cc = Console.ForegroundColor;
                        break;
                    }
            }
            return cc;
        }
    }
}
