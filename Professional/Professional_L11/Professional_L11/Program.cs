using System;
using System.Threading;

namespace Professional_L11
{
    /*
     * Используя конструкции блокировки, модифицируйте последний пример урока таким образом, 
     * чтобы получить возможность поочередной работы 3-х потоков.
    */

    class Program
    {
        static private int counter = 0;

        static private object block = new object();

        static private void Function()
        {
            for (int i = 0; i < 50; ++i)
            {                
                try
                {
                    Monitor.Enter(block);
                    Console.WriteLine(++counter + " - Tread ID: " + Thread.CurrentThread.ManagedThreadId);
                }
                finally
                {
                    Monitor.Exit(block);
                }
            }
        }

        static void Main()
        {
            Thread[] threads = { new Thread(Function), new Thread(Function), new Thread(Function) };

            foreach (Thread t in threads)
            {
                t.Start();
                t.Join();
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
