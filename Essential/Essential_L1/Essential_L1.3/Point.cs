using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1._3
{
    class Point
    {        
        public Point(int x, int y, string pointName)
        {
            X = x;
            Y = y;
            PointName = pointName;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public string PointName { get; private set; }
    }
}
