using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var newYear = new Collection<Month>();
            newYear.Add(new Month("January", 1, 31));
            newYear.Add(new Month("February", 2, 28));
            newYear.Add(new Month("March", 3, 31));
            newYear.Add(new Month("April", 4, 30));
            newYear.Add(new Month("May", 5, 31));
            newYear.Add(new Month("June", 6, 30));
            newYear.Add(new Month("July", 7, 31));
            newYear.Add(new Month("August", 8, 31));
            newYear.Add(new Month("September", 9, 30));
            newYear.Add(new Month("October", 10, 31));
            newYear.Add(new Month("November", 11, 30));
            newYear.Add(new Month("December", 12, 31));

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
