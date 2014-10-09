using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace Professional_L5
{
    class Program
    {
        /*
         * Создайте .xml файл, который соответствовал бы следующим требованиям: 
         * · имя файла: TelephoneBook.xml · корневой элемент: “MyContacts”
         * · тег “Contact” , и в нем должно быть записано имя контакта и атрибут “TelephoneNumber” со значением номера телефона.
        */

        static void Main(string[] args)
        {
            var myXmlDoc = new XmlTextWriter("TelephoneBook.xml", null)
            {
                Formatting = Formatting.Indented
            };

            myXmlDoc.WriteStartDocument();
            myXmlDoc.WriteStartElement("MyContacts");
            myXmlDoc.WriteStartElement("Contact");
            myXmlDoc.WriteStartAttribute("TelephoneNumber");
            myXmlDoc.WriteString("(571)365-4585");
            myXmlDoc.WriteEndAttribute();
            myXmlDoc.WriteString("Jen_Ramee");
            myXmlDoc.WriteEndElement();
            myXmlDoc.WriteStartElement("Contact");
            myXmlDoc.WriteStartAttribute("TelephoneNumber");
            myXmlDoc.WriteString("(571)235-8569");
            myXmlDoc.WriteEndAttribute();
            myXmlDoc.WriteString("Ellen_Moyer");
            myXmlDoc.WriteEndElement();
            myXmlDoc.WriteStartElement("Contact");
            myXmlDoc.WriteStartAttribute("TelephoneNumber");
            myXmlDoc.WriteString("(571)852-7412");
            myXmlDoc.WriteEndAttribute();
            myXmlDoc.WriteString("Michelle_Cloney");
            myXmlDoc.WriteEndElement();
            myXmlDoc.WriteEndElement();

            myXmlDoc.Close();
        }
    }
}
