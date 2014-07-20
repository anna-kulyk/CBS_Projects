using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1._3
{
    class Figure
    {
        Point[] points;

        private string _figureType;
        
        public Figure()
        { }

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            _figureType = "triangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[4];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            _figureType = "quadrangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[5];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            points[4] = point5;
            _figureType = "pentagon";
        }

        public string FigureType
        {
            get { return _figureType; }
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length; i++)
            {
                if (i != points.Length - 1)
                {
                    perimeter += LengthSide(points[i], points[i + 1]);
                }
                else
                {
                    perimeter += LengthSide(points[i], points[0]);
                }
            }

            Console.WriteLine("Perimeter of the {0} is: {1:N}", FigureType, perimeter);
        }
    }
}
