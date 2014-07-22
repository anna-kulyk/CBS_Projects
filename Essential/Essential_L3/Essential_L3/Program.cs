using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello World!";

            Printer[] printers = new Printer[]
            {
                new Canon(),
                new Epson(),
                new HewlettPackard()
            };

            foreach (var printer in printers)
            {
                printer.Print(test);
            }
        }
    }
}
