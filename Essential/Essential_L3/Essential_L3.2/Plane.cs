using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3._2
{
    class Plane : Vehicle
    {
        public Plane(double price, uint speed, uint year, double height, uint capacity)
            : base(price, speed, year)
        {
            Height = height;
            Capacity = capacity;
        }

        protected override string Name { get { return "PLANE"; } }

        public double Height { get; set; }
        public uint Capacity { get; set; }

        public override void ShowProperties()
        {
            base.ShowProperties();
            Console.WriteLine("Height: {1}{0}Capacity: {2}", Environment.NewLine, Height, Capacity);
        } 
    }
}
