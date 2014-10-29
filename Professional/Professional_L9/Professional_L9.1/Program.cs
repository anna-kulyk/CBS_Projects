using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    var myClass = new MyClass();
                    Console.WriteLine("Object {0} is created", myClass.GetHashCode());
                    myClass.Dispose();
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
