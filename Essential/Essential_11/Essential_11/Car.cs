using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_11
{
    class Car
    {
        public Car() { }

        public Car(string name, uint year)
        {
            Name = name;
            Year = year;
        }

        public string Name { get; set; }
        public uint Year { get; set; }

        public override string ToString()
        {
            return string.Format(Name + " - " + Year);
        }
    }
}
