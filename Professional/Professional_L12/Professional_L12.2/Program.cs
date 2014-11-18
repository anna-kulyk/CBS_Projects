using System;
using System.Threading;

namespace Professional_L12._2
{
    //Преобразуйте пример событийной блокировки таким образом, чтобы вместо ручной обработки использовалась автоматическая.

    class Work
    {
        readonly AutoResetEvent _auto;
        readonly Thread _thread;

        public Work(string name, AutoResetEvent auto)
        {
            _thread = new Thread(this.Run) { Name = name };
            _auto = auto;
            _thread.Start();
        }

        void Run()
        {
            Console.WriteLine("Запущен поток " + _thread.Name);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(200);
            }

            Console.WriteLine("\nПоток " + _thread.Name + " завершен");

            // Уведомление о событии происходит при помощи вызова метода Set()
            _auto.Set();
        }
    }

    class AutoResetEventDemo
    {
        static void Main()
        {
            // false - установка несигнального состояния.
            var auto = new AutoResetEvent(false);

            var thread = new Work("1", auto);
            Console.WriteLine("Основной поток ожидает событие.\n");

            auto.WaitOne(); // Ожидать уведомления о событии. 
            Console.WriteLine("\nОсновной поток получил уведомление о событии от первого потока.\n");

            thread = new Work("2", auto);
            Console.WriteLine("Основной поток ожидает событие.\n");

            auto.WaitOne(); // Ожидать уведомления о событии. 
            Console.WriteLine("\nОсновной поток получил уведомление о событии от второго потока.");

            // Delay.
            Console.ReadKey();
        }
    }
}
