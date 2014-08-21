using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L3._1
{
    //Создайте файл, запишите в него произвольные данные и закройте файл. Затем снова откройте этот файл, прочитайте из него данные и выведете их на консоль.

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"H:\test.txt";

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (var sw = new StreamWriter(fs))
                {
                    string text1 = "Hello ";
                    string text2 = "World!";
                    sw.Write(text1);
                    sw.WriteLine(text2);
                }                
            }

            using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sr.ReadLine();
                    }                    
                }
            }
        }
    }
}
