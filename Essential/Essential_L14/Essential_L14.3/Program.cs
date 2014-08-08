using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L14._3
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

            string[] booksArray = books.GetArray<string>();
            foreach (var item in booksArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
