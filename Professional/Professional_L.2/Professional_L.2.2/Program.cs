using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<long, double>();
            accounts.Add(29244825509100, 1000000.25);
            accounts.Add(29244825509250, 250369.75);
            accounts.Add(29244825508233, 5000004.89);
            foreach (var item in accounts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));

            var accounts2 = new SortedList<long, double>();
            accounts2[29244825509100] = 1000000.25;
            accounts2[29244825509250] = 250369.75;
            accounts2[29244825508233] = 5000004.89;
            foreach (var item in accounts2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
