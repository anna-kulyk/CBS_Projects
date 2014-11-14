using System;
using System.IO;
using System.Threading;

namespace Professional_L12
{
    /*
     * Создайте Semaphore , осуществляющий контроль доступа к ресурсу из нескольких потоков. 
     * Организуйте упорядоченный вывод информации о получении доступа в специальный *.log файл
    */

    class Program
    {
        private static Semaphore pool;

        private static object locker = new object();

        private static string path = "Semaphore.log";

        private static void DoWork(object num)
        {
            pool.WaitOne();

            lock (locker)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Thread {0} enters the semaphore.", num);
                }
            }            

            Thread.Sleep(2000); // Do some work.

            lock (locker)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Thread {0} releases the semaphore.", num);
                }
            }            

            pool.Release();
        }

        static void Main(string[] args)
        {
            pool = new Semaphore(4, 4);

            for (int i = 1; i < 9; i++)
            {
                var thread = new Thread(new ParameterizedThreadStart(DoWork));
                thread.Start(i);
            }
        }
    }
}
