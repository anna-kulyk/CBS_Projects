using System;
using System.IO;
using Address;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Professional_L8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            NewAddress address;

            string path = @"H:\Projects\Labs\Professional\Professional_L8\Professional_L8.1\bin\Debug\Second_Address.xml";

            try
            {
                var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                var serializer = new XmlSerializer(typeof(NewAddress));
                address = serializer.Deserialize(stream) as NewAddress;
                Console.WriteLine("Address: {0}, {1}, {2}, {3}, {4}", address.street, address.appartment, address.city, address.country, address.zip);
                stream.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}
