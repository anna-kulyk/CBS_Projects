using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L16._2
{
    class House
    {
        public uint Height { get; set; }
        public uint InnerArea { get; set; }
        public Street StreetName { get; set; }

        public House(uint height, uint innerArea, Street streetName)
        {
            Height = height;
            InnerArea = innerArea;
            StreetName = streetName;
        }

        public House Clone()
        {
            return new House(this.Height, this.InnerArea, this.StreetName);
        }

        public House DeepClone()
        {
            return new House(this.Height, this.InnerArea, new Street(this.StreetName.Name));
        }

        public override string ToString()
        {
            return string.Format("Height: {0}m Inner area: {1}m2 Street: {2}", Height, InnerArea, StreetName.Name);
        }
    }
}
