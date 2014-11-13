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

        private static void ReadWrite(object sourceFileName)
        {
            using (var reader = new StreamReader((string)sourceFileName))
            {
                while (!reader.EndOfStream)
                {
                    var currentRead = reader.ReadLine();

                    lock (locker)
                    {
                        sw.WriteLine(currentRead);
                    }
                    Thread.Sleep(100);
                }
            }
        }

        static void Main(string[] args)
        {
            Thread[] treads = new Thread[] { new Thread(new ParameterizedThreadStart(ReadWrite)), new Thread(new ParameterizedThreadStart(ReadWrite)) };

            treads[0].Start("First.txt");
            Thread.Sleep(50);
            treads[1].Start("Second.txt");

            for (int i = 0; i < treads.Length; i++)
            {
                treads[i].Join();
            }
            sw.Close();
        }
    }
}
