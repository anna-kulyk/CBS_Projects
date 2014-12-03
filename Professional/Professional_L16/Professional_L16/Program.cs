using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L16
{
    /*
     * Создайте метод, который позволит выполнять над коллекцией целых чисел простейшие преобразования, 
     * возвращая в качестве результата новую коллекцию данных. 
     * Используя возможности функционального программирования, выполните над коллекцией следующие операции: 
     * · Увеличьте каждое значение в 2 раза 
     * · Замените каждое нечетное значение ближайшим четным (по возрастанию)
    */

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 4, 8, 2, 0, 3, 6, 7, 9 };

            Console.WriteLine("Numbers:");
            foreach (var item in numbers)
            {
                Console.Write("{0}  ", item);
            }
            Console.WriteLine();

            var numbersx2 = numbers.Select(x => x * 2);

            Console.WriteLine("Doubled numbers:");
            foreach (var item in numbersx2)
            {
                Console.Write("{0}  ", item);
            }
            Console.WriteLine();

            var numbersEven = numbers.Select(x => ((x % 2) == 0)? x : ++x);

            Console.WriteLine("Even numbers:");
            foreach (var item in numbersEven)
            {
                Console.Write("{0}  ", item);
            }
        }
    }
}
