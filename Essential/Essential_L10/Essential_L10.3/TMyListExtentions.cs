using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L10._3
{
    static class TMyListExtentions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.ListLength];
            for (uint i = 0; i < list.ListLength; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
    }
}
