using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L4
{
    abstract class DocumentParts
    {
        protected string content;
        abstract public string Content { get; set; }

        protected virtual ConsoleColor ShowForegroundColor
        {
            get
            {
                return ConsoleColor.Gray;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ShowForegroundColor;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
