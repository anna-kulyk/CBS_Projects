using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Integers integersSquared = GetSquared(integers);

            foreach (var item in integersSquared)
            {
                Console.WriteLine(item);
            }
        }

        static Integers GetSquared(int[] array)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
			{
                newArray[i] = array[i] * array[i];			 
			}

            return new Integers(newArray);
        }
    }
}
