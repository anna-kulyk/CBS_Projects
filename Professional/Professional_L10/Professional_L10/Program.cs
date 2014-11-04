using System;
using System.Collections.Generic;
using Base;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L10
{
    // Реализуйте шаблон NVI в собственной иерархии наследования.

    class DerivedClass : BaseClass
    {
        protected override void DoSpecificWork()
        {
            Console.WriteLine("DerivedClass.DoSpecificWork()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new DerivedClass();
            bc.DoWork();
        }
    }
}
