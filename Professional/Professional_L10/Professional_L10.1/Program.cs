using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L10._1
{
    /* Выучите описание шаблона Template method (Шаблонный метод). 
     * Обратите внимание на применимость шаблона, а также на состав его участников и связи отношения между ними. 
     * Напишите небольшую программу на языке C#, представляющую собой абстрактную реализацию данного шаблона.
    */

    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass[] array = { new ConcreteClassA(), new ConcreteClassB() };

            foreach (var item in array)
            {
                item.TemplateMethod();
            }
        }
    }
}
