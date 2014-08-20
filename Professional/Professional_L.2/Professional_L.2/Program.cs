using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySortedList = new SortedList();

            mySortedList.Add("Tolkien J.R.R.", "The Lord of the Rings");
            mySortedList.Add("Rowling J.K.", "Harry Potter and the Philosopher's Stone");
            mySortedList.Add("Salinger J.D.", "The Catcher in the Rye");
            mySortedList.Add("Brown Dan", "The Da Vinci Code");
            mySortedList.Add("Meyer Stephenie", "Twilight");

            foreach (DictionaryEntry item in mySortedList)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
            Console.WriteLine(new string('-', 50));

            var mySortedList2 = new SortedList(new InvertedComparer());

            mySortedList2.Add("Tolkien J.R.R.", "The Lord of the Rings");
            mySortedList2.Add("Rowling J.K.", "Harry Potter and the Philosopher's Stone");
            mySortedList2.Add("Salinger J.D.", "The Catcher in the Rye");
            mySortedList2.Add("Brown Dan", "The Da Vinci Code");
            mySortedList2.Add("Meyer Stephenie", "Twilight");

            foreach (DictionaryEntry item in mySortedList2)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
