using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = MyClass<int>.FactoryMethod();
            Console.WriteLine(i);
        }
    }
}
