using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStore = new Store();
            Console.WriteLine(myStore[1]);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(myStore[4]);
            Console.WriteLine(new string('-', 30));
            Console.Write("Enter the name of the article: ");
            string s = Console.ReadLine();
            Console.WriteLine(myStore[s]); ;
        }
    }
}
