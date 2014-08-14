using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L18_dll
{
    public class MyClass
    {
        public void MyMethod()
        {            
            Console.WriteLine(Assembly.GetExecutingAssembly().FullName.ToString());
        }
    }
}
