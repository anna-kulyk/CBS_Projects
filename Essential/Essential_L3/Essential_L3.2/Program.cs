using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car(12000, 34, 2006);
            myCar.ShowProperties();
            var myPlane = new Plane(35600, 10, 2011, 158, 66);
            myPlane.ShowProperties();
        }
    }
}
