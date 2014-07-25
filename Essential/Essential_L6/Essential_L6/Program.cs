using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(9, 3));
            Console.WriteLine(Calculator.Subtract(9, 3));
            Console.WriteLine(Calculator.Multiply(9, 3));
            Console.WriteLine(Calculator.Divide(9, 3));
        }
    }
}
