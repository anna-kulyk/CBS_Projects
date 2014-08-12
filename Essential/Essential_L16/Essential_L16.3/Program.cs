using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L16._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = new Date(2014, 08, 12);
            var date2 = new Date(2014, 08, 18);
            int days = Date.GetAmountOfDays(date1, date2);
            Console.WriteLine(days);
            var date3 = date1.AddDays(14);
            Console.WriteLine(date3);
        }
    }
}
