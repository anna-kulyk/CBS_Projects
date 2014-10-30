using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L9._2
{
    /*
     * Создайте класс, который позволит выполнять мониторинг ресурсов, используемых программой. 
     * Используйте его в целях наблюдения за работой программы, а именно: 
     * пользователь может указать приемлемые уровни потребления ресурсов (памяти), 
     * а методы класса позволят выдать предупреждение, когда количество реально используемых ресурсов 
     * приблизиться к максимально допустимому уровню.
    */

    class LargeObject
    {
        int[] array = new int[1000000];
    }

    class Program
    {
        static void Main(string[] args)
        {
            var array = new LargeObject[1000];
            var limit = 1000000000;
            long totalMemory;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new LargeObject();
                totalMemory = GC.GetTotalMemory(false);

                if (totalMemory > limit)
                {
                    Console.WriteLine("You reached the allocated memory limit!");
                    break;
                }

                Console.WriteLine("Counter: {0}", i);
                Console.WriteLine("Total allocated memory: {0}", totalMemory);
            }
        }
    }
}
