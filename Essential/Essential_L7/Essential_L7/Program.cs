using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L7
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook myBook = new Notebook("ProBook 470 G1", "HP", 794);
            myBook.ShowNotebook();
        }
    }
}
