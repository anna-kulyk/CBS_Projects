using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L14._2
{
    class MyDictionary<TKey, TValue> : IEnumerable
    {
        private TKey[] key = new TKey[0];
        private TValue[] value = new TValue[0];

        public int Count
        {
            get
            {
                return key.Length;
            }
        }

        public void AddItem(TKey k, TValue v)
        {
            Array.Resize<TKey>(ref key, key.Length + 1);
            Array.Resize<TValue>(ref value, value.Length + 1);
            key[key.Length - 1] = k;
            value[value.Length - 1] = v;
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < key.Length; i++)
            {
                yield return key[i] + " - " + value[i];
            }
        }

        public string this[TKey index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i].Equals(index))
                    {
                        return key[i] + " - " + value[i];
                    }
                }

                return string.Format("There is no translation for {0}.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    return key[index] + " - " + value[index];
                }
                else
                {
                    return "Index is out of range!";
                }
            }
        }
    }
}
