using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L16
{
    struct Point
    {
        public int X, Y, Z;

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", this.X, this.Y, this.Z);
        }
    }
}
