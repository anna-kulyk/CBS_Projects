using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L9
{
    class Program
    {
        delegate double MyDelegate(int a, int b, int c);

        static void Main(string[] args)
        {
            MyDelegate average = delegate(int a, int b, int c) { return (double)(a + b + c) / 3; };
            double result = average(2, 5, 9);
            Console.WriteLine(result);
        }
    }
}
