using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L6
{
    static class Calculator
    {
        public static double Add(double a, double b)
        {
            return (a + b);
        }

        public static double Subtract(double a, double b)
        {
            return (a - b);
        }

        public static double Multiply(double a, double b)
        {
            return (a * b);
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.Write("You cannot divide by ");
                return 0;
            }
            return (a / b);
        }

    }
}
