using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            var numbers = new int[1000000];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 1000);
            }
            
            var odds = from number in numbers.AsParallel()
                       where (number % 2) != 0
                       select number;

            foreach (var odd in odds)
            {
                Console.Write(odd + "  ");
            }
        }
    }
}
