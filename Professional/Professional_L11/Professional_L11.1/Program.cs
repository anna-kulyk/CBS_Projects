using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;


namespace Professional_L11._1
{
    /*
     * Создайте консольное приложение, которое в различных потоках сможет получить доступ к 2- м файлам. 
     * Считайте из этих файлов содержимое и попытайтесь записать полученную информацию в третий файл. 
     * Чтение/запись должны осуществляться одновременно в каждом из дочерн их потоков. 
     * Используйте блокировку потоков для того, чтобы добиться корректной записи в конечный файл.
    */

    class Program
    {
        private static object locker = new object();
        private static StreamWriter sw = new StreamWriter("Third.txt");

        private static void ReadWrightFirst()
        {
            List<string> first = new List<string>();

            using (StreamReader sr1 = new StreamReader("First.txt"))
            {
                while (!sr1.EndOfStream)
                {
                    first.Add(sr1.ReadLine());
                }
                
            }

            foreach (var item in first)
            {
                lock(locker)
                {
                    sw.WriteLine(item);
                    Thread.Sleep(100);
                }                
            }
            
        }

        private static void ReadWrightSecond()
        {
            List<string> second = new List<string>();

            using (StreamReader sr2 = new StreamReader("Second.txt"))
            {
                while (!sr2.EndOfStream)
                {
                    second.Add(sr2.ReadLine());
                }

            }

            foreach (var item in second)
            {
                lock (locker)
                {
                    sw.WriteLine(item);
                    Thread.Sleep(100);
                }
            }
        }

        static void Main(string[] args)
        {
            Thread[] treads = new Thread[] { new Thread(ReadWrightFirst), new Thread(ReadWrightSecond) };
            for (int i = 0; i < treads.Length; i++)
            {
                treads[i].Start();
                Thread.Sleep(50);
            }
            for (int i = 0; i < treads.Length; i++)
            {
                treads[i].Join();
            }
            sw.Close();
        }
    }
}
