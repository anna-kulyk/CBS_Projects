using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1._1
{
    class Month
    {
        public Month() { }

        public Month(string name, uint consecutiveNumber, uint numberOfDays)
        {
            Name = name;
            ConsecutiveNumber = consecutiveNumber;
            NumberOfDays = numberOfDays;
        }

        public string Name { get; set; }
        public uint ConsecutiveNumber { get; set; }
        public uint NumberOfDays { get; set; }
    }
}
