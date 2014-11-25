using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Professional_L14._1
{
    /*
     * Создайте два метода, которые будут выполняться в рамках параллельных задач. 
     * Организуйте вызов этих методов при помощи Invoke таким образом, 
     * чтобы основной поток программы (метод Main) не остановил свое выполнение.
    */

    class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method1() запущен.");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе Method1(), счетчик равен: " + count);
            }
            Console.WriteLine("Method1() завершен.");
        }

        static void Method2()
        {
            Console.WriteLine("Method2() запущен.");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе Method2(), счетчик равен: " + count);
            }
            Console.WriteLine("Method2() завершен.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");

            Task.Factory.StartNew(() => Parallel.Invoke(Method1, Method2));

            Console.WriteLine("Основной поток завершен.");

            Console.ReadKey();
        }
    }
}
