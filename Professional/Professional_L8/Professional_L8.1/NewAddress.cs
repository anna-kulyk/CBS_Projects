using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Professional_L8._1
{
    [XmlRoot("Address")]
    public class NewAddress
    {        
        public string street;
        public string appartment;
        public string city;
        public string country;
        [XmlAttribute]
        public uint zip;

        public NewAddress() { }
    }
}
