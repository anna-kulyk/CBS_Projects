using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L4
{
    class Body : DocumentParts
    {        
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Тело документа отсутствует.";
            }
            set
            {
                content = value;
            }
        }

        protected override ConsoleColor ShowForegroundColor
        {
            get
            {
                return ConsoleColor.Blue;
            }
        }
    }
}
