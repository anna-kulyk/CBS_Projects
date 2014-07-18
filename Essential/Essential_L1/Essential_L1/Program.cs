using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address myAddress = new Address
            {
                Index = 20191,
                Country = "US",
                City = "Reston",
                Street = "Sentinel Point Ct",
                House = "11947"
            };

            Console.WriteLine(myAddress);
            Console.ReadKey();
        }
    }
}
