using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L8._1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Enter the string: ");
            string pString = Console.ReadLine();
            Console.Write("Enter the color: ");
            string color = Console.ReadLine();
            Printer.Print(pString, color);
        }
    }
}
