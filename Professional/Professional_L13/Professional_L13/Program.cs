using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace Professional_L13
{
    /*
     * Создайте консольное приложение, в котором организуйте асинхронный вызов метода. 
     * Используя конструкцию BeginInvoke передайте в поток некоторую информацию (возможно, в формате строки). 
     * Организуйте обработку переданных данных в callback методе.
    */

    class Program
    {
        static int Multiply(int a, int b)
        {
            return (a * b);
        }

        static void CallbackMethod(IAsyncResult ar)
        {
            var result = (AsyncResult)ar;

            var callerDelegate = (Func<int, int, int>)result.AsyncDelegate;

            int c = callerDelegate.EndInvoke(result);

            Console.WriteLine((string)ar.AsyncState, c);
        }

        static void Main(string[] args)
        {
            var caller = new Func<int, int, int>(Multiply);

            caller.BeginInvoke(2, 5, CallbackMethod, "a * b = {0}");

            Console.ReadKey();

        }
    }
}
