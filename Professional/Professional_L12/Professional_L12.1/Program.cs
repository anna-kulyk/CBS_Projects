using System;
using System.Threading;

namespace Professional_L12._1
{
    //Создайте приложение, которое может быть запущено только в одном экземпляре (используя именованный Mutex) .

    class Program
    {
        private const string uniqueMutexName = "Mutex12";     

        static void Main(string[] args)
        {
            Mutex myMutex = null;

            try
            {
                myMutex = Mutex.OpenExisting(uniqueMutexName);
            }
            catch (WaitHandleCannotBeOpenedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (myMutex != null)
            {
                return;
            }

            myMutex = new Mutex(false, uniqueMutexName);

            Console.WriteLine("Working...");
            Console.ReadKey();
        }
    }
}
