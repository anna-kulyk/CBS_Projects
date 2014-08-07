using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L14
{
    class Program
    {
        static void Main(string[] args)
        {
            var intCollection = new MyIntCollection(10);
            foreach (var item in intCollection.EvenNumbers())
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
