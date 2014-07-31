using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L10
{
    class MyClass<T> where T: new ()
    {
        static public T FactoryMethod()
        {
            T mc = new T();
            return mc;
        }
    }
}
