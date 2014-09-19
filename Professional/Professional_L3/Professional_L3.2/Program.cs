using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L3._2
{
    //Напишите приложение для поиска заданного файла на диске. Добавьте код, 
    //использующий класс FileStream и позволяющий просматривать файл в текстовом окне. 
    //В заключение добавьте возможность сжатия найденного файла.

    class Program
    {   
        static void Main(string[] args)
        {

            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine();
            string root = @"H:\";
            FileInfo fileInfo = Searcher.SearchFile(fileName, root);
            if (fileInfo != null)
            {
                Console.WriteLine("Found: {0}", fileInfo.FullName);
                Console.WriteLine();

                using (var fs = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read))
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

                using (var fs = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read))
                {
                    FileStream destination = File.Create(string.Format(fileInfo.Directory + @"\archive.zip"));

                    using (GZipStream compressor = new GZipStream(destination, CompressionMode.Compress))
                    {
                        int theByte = fs.ReadByte();
                        while (theByte != -1)
                        {
                            compressor.WriteByte((byte)theByte);
                            theByte = fs.ReadByte();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Cannot find file {0}", fileName);
            }
            Console.ReadKey();            
        }
    }
}

