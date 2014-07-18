using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Essential_L1
{
    class Address
    {
        public uint Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Appartment { get; set; }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                                 "Index: {1}{0}Country: {2}{0}City: {3}{0}Street: {4}{0}House: {5}{0}Appartment: {6}{0}",
                                 Environment.NewLine,
                                 Index,
                                 Country,
                                 City,
                                 Street,
                                 House,
                                 Appartment);
        }
    }
}
