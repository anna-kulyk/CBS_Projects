using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Professional_16._1
{
    // Используя возможности класса Expression , сформируйте выражение, 
    // реализующее следующее математическое выражение: y = 2 * (x – 3) + x – 4.


    class Program
    {
        static void Main(string[] args)
        {
            var x = Expression.Parameter(typeof(int), "x");

            var c1 = Expression.Constant(2);
            var c2 = Expression.Constant(3);
            var c3 = Expression.Constant(4);

            var first = Expression.Subtract(x, c2);
            var second = Expression.Multiply(c1, first);
            var third = Expression.Add(second, x);
            var forth = Expression.Subtract(third, c3);

            var expression = Expression.Lambda<Func<int, int>>(forth, x);

            Console.WriteLine(expression);

            Func<int, int> func = expression.Compile();

            Console.WriteLine("If x = 5, the result is {0}", func(5));
        }
    }
}
