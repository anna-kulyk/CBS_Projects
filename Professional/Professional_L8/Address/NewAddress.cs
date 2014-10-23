using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Address
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
    }
}
