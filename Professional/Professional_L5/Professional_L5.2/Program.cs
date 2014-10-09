using System;
using System.Xml;

namespace Professional_L5._2
{
    class Program
    {
        /*
         * Из файла TelephoneBook.xml (файл должен был быть создан в процессе выполнения дополнительного задания) 
         * выведите на экран только номера телефонов.
        */

        static void Main(string[] args)
        {
            string path = @"H:\Projects\Labs\Professional\Professional_L5\Professional_L5\bin\Debug\TelephoneBook.xml";

            var reader = new XmlTextReader(path);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            Console.WriteLine(reader.Value);
                        }
                    }
                }
            }
        }
    }
}
