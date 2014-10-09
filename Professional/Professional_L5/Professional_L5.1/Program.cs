using System;
using System.Xml;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L5._1
{
    class Program
    {
        /*
         * Создайте приложение, которое выводит на экран всю информацию об указанном .xml файле.
        */

        static void Main(string[] args)
        {
            string path = @"H:\Projects\Labs\Professional\Professional_L5\Professional_L5\bin\Debug\TelephoneBook.xml";

            var stream = new FileStream(path, FileMode.OpenOrCreate);
            var reader = new XmlTextReader(stream);

            while (reader.Read())
            {
                Console.WriteLine("{0, -10} {1, -10} {2, -10}",
                                  reader.NodeType,
                                  reader.Name,
                                  reader.Value);
            }

            reader.Close();
        }
    }
}
