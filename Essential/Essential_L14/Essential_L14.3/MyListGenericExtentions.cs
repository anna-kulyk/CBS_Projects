using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L14._3
{
    static class MyListGenericExtentions
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            var array = new T[0];

            foreach(var item in list)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = item;
            }

            return array;
        }
    }
}
