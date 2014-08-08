using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> books = new MyList<string>();
            books.AddItem("Harry Potter and the Philosopher's Stone");
            books.AddItem("Harry Potter and the Chamber of Secrets");
            books.AddItem("Harry Potter and the Prisoner of Azkaban");
            books.AddItem("Harry Potter and the Goblet of Fire");
            books.AddItem("Harry Potter and the Order of the Phoenix");
            books.AddItem("Harry Potter and the Half-Blood Prince");
            books.AddItem("Harry Potter and the Deathly Hallows");

            Console.WriteLine("There are {0} books in the list.", books.Count);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("The first in the list is: {0}", books[0]);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
        }
    }
}
