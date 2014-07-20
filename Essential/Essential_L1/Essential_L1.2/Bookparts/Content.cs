using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1._2
{
    class Content
    {
        public string Text { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Content: {0}", Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
