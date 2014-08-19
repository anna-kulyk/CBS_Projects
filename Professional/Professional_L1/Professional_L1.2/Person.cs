using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1._2
{
    class Person
    {
        public Person() { }

        public Person(string name, uint year)
        {
            Name = name;
            Year = year;
            Heirs = new Collection<Person>();
        }

        public Person(string name, uint year, Collection<Person> heirs)
            :this(name, year)
        {
            Heirs = heirs;
        }

        public string Name { get; set; }
        public uint Year { get; set; }
        public Collection<Person> Heirs { get; set; }
    }
}
