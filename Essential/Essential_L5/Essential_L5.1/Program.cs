using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArrey = new MyArray();

            Console.WriteLine("Max: {0}", myArrey.Max());
            Console.WriteLine("Min: {0}", myArrey.Min());
            Console.WriteLine("Sum: {0}", myArrey.Sum());
            Console.WriteLine("Average: {0}", myArrey.Average());
            var odds = myArrey.GetOdds();
            Console.Write("Odds: ");
            foreach (var odd in odds)
            {
                Console.Write(odd + "  ");
            }
        }
    }
}
