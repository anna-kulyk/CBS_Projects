using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFigure = new Figure
            (
                new Point(4, 2, "A"),
                new Point(7, 7, "B"),
                new Point(8, -1, "C")
            );

            myFigure.PerimeterCalculator();
        }
    }
}
