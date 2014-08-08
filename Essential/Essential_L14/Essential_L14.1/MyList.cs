using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L14._1
{
    class MyList<T> : IEnumerable<T>, IEnumerable
    {
        private T[] list = new T[0];

        public int Count
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Length; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
