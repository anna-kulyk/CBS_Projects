using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1._2
{
    class Author
    {
        public string Text { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Author: {0}", Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
