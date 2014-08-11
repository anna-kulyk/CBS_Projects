using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L15
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;

            try
            {
                result = Calculator.Divide(5, 0);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }            
        }
    }
}
