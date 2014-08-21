using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L._2._3
{
    class Program
    {
        // Мой вариант
        static void AddSorted(OrderedDictionary od, object x, object y)
        {
            var d = new SortedDictionary<object, object>();
            foreach (DictionaryEntry item in od)
            {
                d.Add(item.Key, item.Value);
            }
            d.Add(x, y);
            od.Clear();
            foreach (KeyValuePair<object, object> item in d)
            {
                od.Add(item.Key, item.Value);
            }
        }

        static void Main(string[] args)
        {
            //Реализация варианта Кости
            var dictionary = new MyOrderedDictionary<string, string>();
            dictionary.Add("Tolkien J.R.R.", "The Lord of the Rings");
            dictionary.Add("Rowling J.K.", "Harry Potter and the Philosopher's Stone");
            dictionary.Add("Salinger J.D.", "The Catcher in the Rye");
            dictionary.Add("Brown Dan", "The Da Vinci Code");
            dictionary.Add("Meyer Stephenie", "Twilight");
            
            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine(new string('-', 50));

            //Реализация моего варианта
            var sortedOD = new OrderedDictionary();
            AddSorted(sortedOD, "Tolkien J.R.R.", "The Lord of the Rings");
            AddSorted(sortedOD, "Rowling J.K.", "Harry Potter and the Philosopher's Stone");
            AddSorted(sortedOD, "Salinger J.D.", "The Catcher in the Rye");
            AddSorted(sortedOD, "Brown Dan", "The Da Vinci Code");
            AddSorted(sortedOD, "Meyer Stephenie", "Twilight");

            foreach (DictionaryEntry item in sortedOD)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
            //Console.WriteLine(sortedOD[0]);

            Console.ReadKey();
        }
    }
}
