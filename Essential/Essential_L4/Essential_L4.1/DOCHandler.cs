using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L4._1
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOCHandler.Open()");
        }
        public override void Create()
        {
            Console.WriteLine("DOCHandler.Create()");
        }
        public override void Change()
        {
            Console.WriteLine("DOCHandler.Change()");
        }
        public override void Save()
        {
            Console.WriteLine("DOCHandler.Save()");
        }
    }
}
