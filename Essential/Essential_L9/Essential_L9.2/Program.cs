using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L9._2
{
    class Program
    {
        delegate double Del2(Del1[] delegates);

        delegate int Del1();

        static void Main(string[] args)
        {
            uint n = 7;
            Del1[] del1 = new Del1[n];
            for (int i = 0; i < del1.Length; i++)
            {
                del1[i] = () =>
                {
                    Random r = new Random();
                    return r.Next(1, 100);
                };                
            }

            Del2 average = delegate(Del1[] dels)
            {
                double sum = 0;
                foreach (var del in dels)
                {
                    sum += del();
                }
                return (double)(sum / dels.Length);
            };

            double result = average(del1);
            Console.WriteLine(result);
        }
    }
}
