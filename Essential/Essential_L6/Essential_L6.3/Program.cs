using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 6, 4, 8, 8, 5, 1 };
            array.LowToHigh();
            foreach (var item in array)
            {
                Console.Write(item + "  ");                
            }
        }
    }
}
