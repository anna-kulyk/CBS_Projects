using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L5._1
{
    class MyArray
    {
        private int[] array;

        public MyArray()
        {
            array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }        

        public int Max()
        {
            int max = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
            }
            return max;
        }

        public int Min()
        {
            int min = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
            }
            return min;
        }

        public int Sum()
        {
            int sum = 0;

            for (var i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public double Average()
        {
            double sum = Sum();
            return (sum / array.Length);
        }

        public int[] GetOdds()
        {
            int[] odds = new int[array.Length];
            int[] getodds;
            int counter = 0;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    odds[counter] = array[i];
                    ++counter;
                }
            }

            if (counter > 0 && counter < array.Length)
            {
                getodds = new int[counter];
                Array.Copy(odds, getodds, counter);
            }
            else if (counter == array.Length)
            {
                getodds = array;
            }
            else
            {
                getodds = new int[0];
            }
            return getodds;            
        }

    }
}
