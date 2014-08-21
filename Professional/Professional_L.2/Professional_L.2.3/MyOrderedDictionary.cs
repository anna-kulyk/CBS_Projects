using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L._2._3
{
    // Вариант Кости
    public sealed class MyOrderedDictionary<TKey, TValue> : IDictionary<TKey, TValue> where TKey : IComparable
    {
        private KeyValuePair<TKey, TValue>[] keyValues = new KeyValuePair<TKey, TValue>[0];

        public void Add(TKey key, TValue value)
        {
            if (ContainsKey(key))
            {
                throw new InvalidOperationException();
            }

            var tempKeyValues = new KeyValuePair<TKey, TValue>[keyValues.Length + 1];
            var j = 0;

            if (keyValues.Length == 0)
            {
                tempKeyValues[0] = new KeyValuePair<TKey, TValue>(key, value);
            }
            else
            { 
                for (var i = 0; i < keyValues.Length; i++)
                {
                    if (j == 0 && key.CompareTo(keyValues[i].Key) < 0)
                    {
                        tempKeyValues[i] = new KeyValuePair<TKey, TValue>(key, value);
                        j++;
                        i--;
                        continue;
                    }
                
                    tempKeyValues[i+j] = keyValues[i];
                }

                if (j == 0)
                {
                    tempKeyValues[tempKeyValues.Length - 1] = new KeyValuePair<TKey, TValue>(key, value);
                }
            }

            keyValues = tempKeyValues;
        }

        public bool ContainsKey(TKey key)
        {
            return keyValues.Any(kv => kv.Key.Equals(key));
        }

        public ICollection<TKey> Keys
        {
            get { return keyValues.Select(kv => kv.Key).ToList(); }
        }

        public bool Remove(TKey key)
        {
            if (!ContainsKey(key))
            {
                return false;
            }

            var tempKeyValues = new KeyValuePair<TKey, TValue>[keyValues.Length - 1];
            var j = 0;

            for (var i = 0; i < keyValues.Length; i++)
            {
                if (key.Equals(keyValues[i].Key))
                {
                    j--;
                    continue;
                }

                tempKeyValues[i+j] = keyValues[i];
            }

            keyValues = tempKeyValues;
            return true;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (ContainsKey(key))
            {
                value = this[key];
                return true;
            }

            value = default(TValue);
            return false;
        }

        public ICollection<TValue> Values
        {
            get { return keyValues.Select(kv => kv.Value).ToList(); }
        }

        public TValue this[TKey key]
        {
            get
            {
                if (ContainsKey(key))
                {
                    return keyValues.Single(kv => kv.Key.Equals(key)).Value;
                }

                throw new KeyNotFoundException();
            }
            set
            {
                if (ContainsKey(key))
                {
                    Remove(key);
                }

                Add(key, value);
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            keyValues = new KeyValuePair<TKey, TValue>[0];
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return ContainsKey(item.Key) && keyValues.Any(kv => kv.Value.Equals(item.Value));
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            if (keyValues.Length <= arrayIndex)
            {
                throw new InvalidOperationException();
            }

            for (int i = arrayIndex, j = 0; i < keyValues.Length; i++, j++)
            {
                array[j] = keyValues[i];
            }
        }

        public int Count
        {
            get { return keyValues.Length; }
        }

        public bool IsReadOnly
        {
            get { return keyValues.IsReadOnly; }
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return Remove(item.Key);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var kv in keyValues) { yield return kv; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return keyValues.GetEnumerator();
        }
    }
}
