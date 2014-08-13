using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L17
{
    class Program
    {
        static void Main(string[] args)
        {
            var operand1 = 20;
            var operand2 = 10;

            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, Calculator.Add(operand1, operand2));
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, Calculator.Subtract(operand1, operand2));
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, Calculator.Multiply(operand1, operand2));
            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, Calculator.Divide(operand1, operand2));
        }
    }
}
