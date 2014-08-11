using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L15._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage myStorage = new Storage(2);
            try
            {
                myStorage.ShowProductsInStore();
            }
            catch(StoreAbsenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
