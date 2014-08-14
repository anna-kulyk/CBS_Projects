using System;
using System.Reflection;
using System.Text;
using Essential_L18_dll;

namespace Essential_L18._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Assembly.GetExecutingAssembly().FullName.ToString());
            MyClass mc = new MyClass();
            mc.MyMethod();
        }
    }
}
