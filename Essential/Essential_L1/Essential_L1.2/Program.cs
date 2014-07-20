using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBook = new Book();

            myBook.BookTitle = "Shantaram";
            myBook.BookAuthor = "Gregory David Roberts";
            myBook.BookContent = "A convicted Australian bank robber and heroin addict who escaped from Pentridge Prison flees to India.";

            myBook.ShowBook();
        }
    }
}
