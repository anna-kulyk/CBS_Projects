using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1._1
{
    class Rectangle
    {
        double _side1, _side2;

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }

        private double AreaCalculator()
        {
            return (_side1 * _side2);
        }

        private double PerimeterCalculator()
        {
            return (_side1 + _side2) * 2;
        }

    }
}
