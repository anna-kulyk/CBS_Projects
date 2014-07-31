using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L10._3
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
            int[] array = list.GetArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
