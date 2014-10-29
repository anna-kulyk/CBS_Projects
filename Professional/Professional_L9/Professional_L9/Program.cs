using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L9
{
    /*
     * Создайте свой класс, объекты которого будут занимать много места в памяти
     * (например, в коде класса будет присутствовать большой массив)
     * и реализуйте для этого класса формализованный шаблон очистки.
    */

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
