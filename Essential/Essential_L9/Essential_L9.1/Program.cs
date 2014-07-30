using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L9._1
{
    class Program
    {
        delegate double ArithmeticOperations(double operand1, double operand2);

        static void Main(string[] args)
        {
            Console.Write("Enter the first operand: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second operand: ");
            double b = Convert.ToDouble(Console.ReadLine());
            ArithmeticOperations ao = null;
            string c = null;
            bool key = true;
            while (key)
            {
                key = false;
                Console.Write("Enter the sign of arithmetic operation (+ - * /): ");
                c = Console.ReadLine();
                switch (c)
                {
                    case "+":
                        {
                            ao = (operand1, operand2) => { return (operand1 + operand2); };
                            break;
                        }
                    case "-":
                        {
                            ao = (operand1, operand2) => { return (operand1 - operand2); };
                            break;
                        }
                    case "*":
                        {
                            ao = (operand1, operand2) => { return (operand1 * operand2); };
                            break;
                        }
                    case "/":
                        {
                            if (b != 0)
                            {
                                ao = (operand1, operand2) => { return (operand1 / operand2); }; 
                            }
                            else
                            {
                                Console.WriteLine("You cannot divide by zero!");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You have entered the wrong sign!");
                            key = true;
                            break;
                        }
                }                
            }
            if (ao != null)
            {
                double result = ao(a, b);
                Console.WriteLine("{0} {1} {2} = {3}", a, c, b, result);
            }            
        }
    }
}
