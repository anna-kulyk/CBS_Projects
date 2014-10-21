using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L7._1
{
    class MyClass
    {
        [Obsolete("This is an obsolete method")]
        public void FirstMethod()
        {
            Console.WriteLine("This is the first obsolete method");
        }

        [Obsolete("You cannot use this metod", true)]
        public void SecondMethod()
        {
            Console.WriteLine("This is the second obsolete method");
        }
    }
}
