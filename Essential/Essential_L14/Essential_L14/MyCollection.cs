using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L14
{
    class MyIntCollection
    {
        private int[] myArray;
        
        public MyIntCollection(int length)
        {
            myArray = new int[length];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }            
        }
        
        public IEnumerable EvenNumbers()
        {
            foreach (var item in myArray)
            {
                if (item % 2 == 0)
                {
                    yield return item;
                }
            }
        }
    }
}
