using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            var newUser = new User("hermy", "Anna", "Kulyk", 25);

            Console.WriteLine(newUser.ToString());
        }
    }
}
