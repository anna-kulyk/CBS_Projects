using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L10._1
{
    public abstract class AbstractClass
    {
        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine(new string('*', 35));
        }
    }
}
