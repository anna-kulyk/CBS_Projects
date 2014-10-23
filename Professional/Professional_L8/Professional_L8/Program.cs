using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L8
{
    class Program
    {
        /*
         * Создайте пользовательский тип (например, класс) и выполните сериализацию объекта этого типа, 
         * учитывая тот факт, что состояние объекта необходимо будет передать по сети.
        */

        static void Main(string[] args)
        {
            var myAddress = new Address("11703 Olde English Dr", "Unit I", "Reston, VA", "USA", 20190);

            var stream = new FileStream("Address.dat", FileMode.OpenOrCreate);
            var formatter = new BinaryFormatter();

            formatter.Serialize(stream, myAddress);
            stream.Close();
        }
    }
}
