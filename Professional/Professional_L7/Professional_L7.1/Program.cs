using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L7._1
{
    /*
     * Создайте класс и примените к его методам атрибут Obsolete
     * сначала в форме просто выводящей предупреждение, а затем в форме, препятствующей компиляции. 
     * Продемонстрируйте работу атрибута на примере вызова данных методов.
    */

    class Program
    {
        static void Main(string[] args)
        {
            var my = new MyClass();

            my.FirstMethod(); // Выводится предупреждение, что метод устаревший, но компиляция продолжается.
            my.SecondMethod(); // Выдается ошибка на уровне компиляции.

        }
    }
}
