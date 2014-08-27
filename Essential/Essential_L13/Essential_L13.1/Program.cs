using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Essential_L13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 35);
            Random rand = new Random();

            Matrix m = new Matrix();
            ParameterizedThreadStart matrix = new ParameterizedThreadStart(m.MatrixString);

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Thread matrixThread = new Thread(matrix);
                matrixThread.Start(rand.Next(1, Console.WindowWidth - 1));
                Thread.Sleep(rand.Next(300, 2000));
            }
        }
    }
}
