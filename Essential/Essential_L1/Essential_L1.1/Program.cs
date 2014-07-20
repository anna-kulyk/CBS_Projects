using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myRectangle = new Rectangle(2, 4);
            Console.WriteLine("Площадь прямоугольнока равна: {0}", myRectangle.Area);
            Console.WriteLine("Периметр прямоугольнока равен: {0}", myRectangle.Perimeter);
        }
    }
}
