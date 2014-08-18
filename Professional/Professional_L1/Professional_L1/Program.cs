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

            IEnumerable<int> integersSquared = GetSquared(integers);

            foreach (var item in integersSquared)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<int> GetSquared(int[] array)
        { 
            for (int i = 0; i < array.Length; i++)
			{
                if (array[i] % 2 !=0)
                {
                    yield return array[i] * array[i]; 
                };			 
			}
        }
    }
}
