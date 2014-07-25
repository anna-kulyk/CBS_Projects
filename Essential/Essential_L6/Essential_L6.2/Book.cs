using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L6._2
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }

        public class Notes
        {
            public static void SaveNotes (string note)
            {
                Console.WriteLine("Note: {0}", note);
            }
        }
    }
}
