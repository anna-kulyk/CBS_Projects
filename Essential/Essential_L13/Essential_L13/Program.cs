using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Essential_L13
{
    class Program
    {        
        static void MyMethod(object count)
        {
            Console.WriteLine("Thread: {0}, count = {1}", Thread.CurrentThread.ManagedThreadId, count);
            if ((int)count > 0)
            {
                count = (int)count - 1;
                ParameterizedThreadStart myMethod = new ParameterizedThreadStart(MyMethod);
                Thread th = new Thread(myMethod);
                th.Start(count);
            }
        }

        static void Main(string[] args)
        {
            MyMethod((object)5);
        }
    }
}
