using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();            
            list.AddItem(8);
            list.AddItem(6);
            list.AddItem(4);
            list.AddItem(2);
            list.AddItem(0);
            Console.WriteLine(list.ListLength);
            Console.WriteLine(new string('-', 10));
            for (uint i = 0; i < list.ListLength; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(list[4]);
            Console.WriteLine(list[5]);
        }
    }
}
