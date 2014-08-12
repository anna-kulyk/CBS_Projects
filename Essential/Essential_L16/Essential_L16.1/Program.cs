using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Block(1, 2, 3, 4);
            var b2 = new Block(2, 3, 4, 5);
            var b3 = new Block(1, 2, 3, 4);

            Console.WriteLine(b1.Equals(b2));
            Console.WriteLine(b1.Equals(b3));
            Console.WriteLine(Object.ReferenceEquals(b1, b3));
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1.GetHashCode());
        }
    }
}
