using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1._3
{
    class Point
    {
        private int _x, _y;
        private string _pointName;

        public Point(int x, int y, string pointName)
        {
            _x = x;
            _y = y;
            _pointName = pointName;
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        public string PointName
        {
            get { return _pointName; }
        }
    }
}
