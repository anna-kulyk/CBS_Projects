using System;
using System.Threading;

namespace Professional_L12._1
{
    //Создайте приложение, которое может быть запущено только в одном экземпляре (используя именованный Mutex) .

    class Program
    {
        private static Mutex myMutex;

        private static void DoWork(object num)
        {
            myMutex.WaitOne();

            Console.WriteLine("Thread {0} has entered the protected area.", num);

            Thread.Sleep(2000); // Do some work.

            Console.WriteLine("Thread {0} is leaving the protected area", num);

            myMutex.ReleaseMutex();
        }

        static void Main(string[] args)
        {
            myMutex = new Mutex();

            for (int i = 1; i < 9; i++)
            {
                var thread = new Thread(new ParameterizedThreadStart(DoWork));
                thread.Start(i);
            }
        }
    }
}
