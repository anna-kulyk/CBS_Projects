using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class BaseClass
    {
        public void DoWork()
        {
            Console.WriteLine("BaseClass.DoWork()");
            DoSpecificWork();
        }

        protected virtual void DoSpecificWork()
        {
            Console.WriteLine("BaseClass.DoSpecificWork()");
        }
    }
}
