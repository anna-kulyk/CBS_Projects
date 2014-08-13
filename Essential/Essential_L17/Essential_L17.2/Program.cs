using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L17._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new[]
            {
                new {English = "apple", Russian = "яблоко"},
                new {English = "pear", Russian = "груша"},
                new {English = "orange", Russian = "апельсин"},
                new {English = "lemon", Russian = "лимон"},
                new {English = "pineapple", Russian = "ананас"},
                new {English = "blueberry", Russian = "черника"},
                new {English = "strawberry", Russian = "клубника"},
                new {English = "raspberry", Russian = "малина"},
                new {English = "cherry", Russian = "вишня"},
                new {English = "banana", Russian = "банан"},
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} - {1}", item.English, item.Russian);
            }
        }
    }
}
