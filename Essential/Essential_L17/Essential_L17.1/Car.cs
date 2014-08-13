using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L17._1
{
    class Car
    {
        public Car(Brand brand, string model, uint year, Color color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
        }

        public Brand Brand { get; set; }
        public string Model { get; set; }
        public uint Year { get; set; }
        public Color Color { get; set; } 
    }
}
