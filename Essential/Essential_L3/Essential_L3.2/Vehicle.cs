using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3._2
{
    class Vehicle
    {
        public Vehicle(double price, uint speed, uint year)
        {
            Price = price;
            Speed = speed;
            Year = year;
        }

        protected virtual string Name { get { return "VEHICLE"; } } 

        public double Price { get; set; }
        public uint Speed { get; private set; }
        public uint Year { get; private set; }

        public virtual void ShowProperties()
        {
            Console.WriteLine("{1} PROPERTIES{0}Price: {2:N}{0}Speed: {3}{0}Year: {4}", Environment.NewLine, Name, Price, Speed, Year);
        }
    }
}
