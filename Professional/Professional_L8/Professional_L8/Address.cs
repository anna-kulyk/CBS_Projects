using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L8
{
    [Serializable]
    public class Address
    {
        private string _street;
        private string _appartment;
        private string _city;
        private string _country;
        private uint _zip;

        public Address(string street, string appartment, string city, string country, uint zip)
        {
            _street = street;
            _appartment = appartment;
            _city = city;
            _country = country;
            _zip = zip;
        }

        public string Street
        {
            get { return _street;}
            set { _street = value;}
        }

        public string Appartment
        {
            get { return _appartment; }
            set { _appartment = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public uint Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public override string ToString()
        {
            return string.Format("Address: {0}, {1}, {2}, {3}, {4}", Street, Appartment, City, Country, Zip);
        }
    }
}
