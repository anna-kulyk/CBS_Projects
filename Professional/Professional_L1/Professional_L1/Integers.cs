using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1
{
    class Integers: IEnumerable
    {
        private int[] _array = new int[0];

        public Integers(int[] array)
        {
            _array = array;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                yield return _array[i];
            }
        }

        public int this[int index]
        {
            get
            {
                return _array[index];
            }
        }
    }
}
