using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3
{
    class HewlettPackard : Printer
    {
        protected override ConsoleColor PrinterColor
        {
            get { return ConsoleColor.Red; }
        }        
    }
}
