using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L10._3
{
    class MyList<T>
    {
        T[] list = new T[0];

        public int ListLength
        {
            get
            {
                return list.Length;
            }
        }

        public void AddItem(T item)
        {
            Array.Resize<T>(ref list, (list.Length + 1));
            list[list.Length - 1] = item;
        }

        public T this[uint index]
        {
            get
            {
                if (index < list.Length)
                {
                    return list[index];
                }
                else
                {
                    Console.WriteLine("Index is out of range!");
                    return default(T);
                }
            }
        }
    }
}
