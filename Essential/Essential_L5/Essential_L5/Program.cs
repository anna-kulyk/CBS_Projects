using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга", Language.RU, Language.EN]);
            Console.WriteLine(dictionary["дом", Language.RU, Language.EN]);
            Console.WriteLine(dictionary["яблуко", Language.UA, Language.EN]);
            Console.WriteLine(dictionary["стол", Language.RU, Language.UA]);
            Console.WriteLine(dictionary["карандаш", Language.RU, Language.UA]);
            Console.WriteLine(dictionary["apple", Language.EN, Language.RU]);
            Console.WriteLine(dictionary["sun", Language.EN, Language.UA]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
