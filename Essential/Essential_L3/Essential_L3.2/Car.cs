using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3._2
{
    class Car : Vehicle
    {
        public Car(double price, uint speed, uint year)
            : base(price, speed, year)
        { }

        protected override string Name { get { return "CAR"; } }
    }
}
