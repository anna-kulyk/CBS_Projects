using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Essential_L13._1
{
    class Matrix
    {
        public void MatrixString(object x)
        {
            object locker = new object();

            string[] array = new string[9];
            array[0] = "f";
            array[1] = "y";
            array[2] = "r";
            array[3] = "v";
            array[4] = "d";
            array[5] = "g";
            array[6] = "a";
            array[7] = "s";
            array[8] = "t";


            while (true)
            {
                for (int j = 0; j < Console.WindowHeight + array.Length; j++)
                {
                    int index = j;
                    if (j < array.Length)
                    {
                        for (int i = 0; i <= j; i++)
                        {

                            Console.SetCursorPosition((int)x, index);
                            if (i == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (i == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                            Console.WriteLine(array[i]);
                            index--;
                        }
                        Thread.Sleep(100);
                    }
                    else
                    {
                        for (int i = 0; i <= array.Length; i++)
                        {
                            if (j < Console.WindowHeight && i != array.Length)
                            {

                                Console.SetCursorPosition((int)x, index);
                                if (i == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (i == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                }
                                Console.WriteLine(array[i]);
                                index--;

                            }
                            else if (i != array.Length)
                            {
                                if (i >= j - Console.WindowHeight + 1)
                                {
                                    index = j - i;
                                    Console.SetCursorPosition((int)x, index);
                                    Console.WriteLine(array[i]);
                                    index--;
                                }
                            }
                            else
                            {
                                index = j - i;
                                Console.SetCursorPosition((int)x, index);
                                Console.WriteLine(" ");
                            }
                        }
                        Thread.Sleep(100);
                        Console.SetCursorPosition((int)x, index);
                        Console.WriteLine(" ");
                    }
                }
            }
        }
    }
}
