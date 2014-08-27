using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Essential_L13._1
{
    static class ChainDisplayer
    {
        static object _lock = new object();
        static Random r = new Random();

        static public void DisplayChain(Chain chain, int x)
        {
            int height = Console.WindowHeight - 2;
            int length = chain.Length;
            int count = 0;
            int countMax = height + length;

            while (count <= countMax)
            {
                lock(_lock)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (chain[i].Y >= 0 && chain[i].Y < height)
                        {
                            Console.SetCursorPosition(x, chain[i].Y);
                            Console.ForegroundColor = chain[i].Color;
                            Console.WriteLine(chain[i].Character);
                            chain[i].Character = Symbol.RandomChar(r);
                        }
                        chain[i].Y++;
                    }
                    if (count >= length)
                    {
                        Console.SetCursorPosition(x, chain[length - 1].Y - 2);
                        Console.WriteLine(" ");
                    }
                    count++;
                }
                Thread.Sleep(80);
            }

        }
    }
}
