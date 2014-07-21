using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var aKulyk = new Employee("Anna", "Kulyk");
            aKulyk.EmployeePost = Post.Accountant;
            aKulyk.Experience = 4;
            aKulyk.EmployeeInformation();
        }
    }
}
