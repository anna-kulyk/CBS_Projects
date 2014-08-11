using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff myStaff = new Staff(5);
            myStaff.ShowIfExperienced(2);
        }
    }
}
