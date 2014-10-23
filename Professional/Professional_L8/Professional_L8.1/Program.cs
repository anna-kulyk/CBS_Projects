using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Professional_L8._1
{
    /*
     * Создайте класс, поддерживающий сериализацию. 
     * Выполните сериализацию объекта этого класса в формате XML. 
     * Сначала используйте формат по умолчанию, а затем измените его таким образом, 
     * чтобы значения полей сохранились в виде атрибутов элементов XML .
    */

    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address { street = "11947 Sentinel Point Ct", city = "Reston, VA", country = "USA", zip = 20191 };
            var naddress = new NewAddress { street = "11703 Olde English Dr", appartment = "Unit I", city = "Reston, VA", country = "USA", zip = 20190 };

            var stream = new FileStream("First_Address.xml", FileMode.OpenOrCreate);
            var serializer = new XmlSerializer(typeof(Address));
            serializer.Serialize(stream, address);
            stream.Close();

            stream = new FileStream("Second_Address.xml", FileMode.OpenOrCreate);
            serializer = new XmlSerializer(typeof(NewAddress));
            serializer.Serialize(stream, naddress);
            stream.Close();
        }
    }
}
