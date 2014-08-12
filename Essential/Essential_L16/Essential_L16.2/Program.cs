using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var house1 = new House(25, 36, new Street("Bogdanivs'ka"));
            var house2 = house1.Clone();
            var house3 = house1.DeepClone();
            Console.WriteLine(house1.ToString());
            Console.WriteLine(house2.ToString());
            Console.WriteLine(house3.ToString());
            Console.WriteLine(new string('-', 30));
            house1.Height = 27;
            house1.StreetName = new Street("Iv.Shevcova");
            Console.WriteLine(house1.ToString());
            Console.WriteLine(house2.ToString());
            Console.WriteLine(house3.ToString());
        }
    }
}
