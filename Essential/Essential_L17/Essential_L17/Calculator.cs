using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L17
{
    static class Calculator
    {
        public static dynamic Add(dynamic operand1, dynamic operand2)
        {
            return operand1 + operand2;
        }

        public static dynamic Subtract(dynamic operand1, dynamic operand2)
        {
            return operand1 - operand2;
        }

        public static dynamic Multiply(dynamic operand1, dynamic operand2)
        {
            return operand1 * operand2;
        }

        public static dynamic Divide(dynamic operand1, dynamic operand2)
        {
            if (operand2 == 0)
            {
                return "You cannot divide by zero!";
            }

            return operand1 / operand2;
        }
    }
}
