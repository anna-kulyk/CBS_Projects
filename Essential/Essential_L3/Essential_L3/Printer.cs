using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3
{
    class Printer
    {
        protected virtual ConsoleColor PrinterColor
        {
            get { return ConsoleColor.Gray; }
        }

        public void Print(string value)
        {
            Console.ForegroundColor = PrinterColor;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
