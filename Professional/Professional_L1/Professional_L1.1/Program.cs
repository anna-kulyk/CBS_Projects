using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var newYear = new Year();

            foreach (var item in newYear)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(new string('-', 30));

            var myMonth = newYear.GetMonthByConsecutiveNumber(9);
            Console.WriteLine(myMonth.Name);

            Console.WriteLine(new string('-', 30));

            IEnumerable<Month> months = newYear.GetMonthByNumberOfDays(31);
            foreach (var item in months)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
