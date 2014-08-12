using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L16
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Point(1, 1, 1);
            var b = new Point(2, 2, 2);
            var c = a + b;
            Console.WriteLine(c);
        }
    }
}
