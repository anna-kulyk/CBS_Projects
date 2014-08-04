using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Essential_L13
{
    class Program
    {
        static int count = 5;

        static void MyMethod()
        {
            Console.WriteLine("Thread: {0}, count = {1}", Thread.CurrentThread.GetHashCode(), count);
            if (count > 0)
            {
                --count;
                Thread th = new Thread(MyMethod);
                th.Start();
            }
        }

        static void Main(string[] args)
        {
            MyMethod();
        }
    }
}
