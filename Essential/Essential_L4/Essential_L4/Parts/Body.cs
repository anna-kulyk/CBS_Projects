using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L4
{
    class Body : DocumentParts
    {
        protected override string EmptyContentErrorMessage { get { return "Тело документа отсутствует."; } }
        
        protected override ConsoleColor ShowForegroundColor
        {
            get
            {
                return ConsoleColor.Blue;
            }
        }
    }
}
