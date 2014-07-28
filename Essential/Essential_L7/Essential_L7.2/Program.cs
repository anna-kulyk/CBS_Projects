using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L7._2
{
    class Program
    {
        static void ClassTaker(MyClass myclass)
        {
            myclass.change = "changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
            //Console.WriteLine(myStruct.change);
        }

        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            ClassTaker(mc);
            Console.WriteLine(mc.change);
            mc.change = "not changed";
            Console.WriteLine(mc.change);
            Console.WriteLine(new string('-', 40));

            MyStruct ms = new MyStruct();
            StructTaker(ms);
            Console.WriteLine(ms.change);
            ms.change = "not changed";
            Console.WriteLine(ms.change);
        }
    }
}
