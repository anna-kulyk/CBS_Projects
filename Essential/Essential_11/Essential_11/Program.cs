using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_11
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carport = new CarCollection<Car>();
            carport.AddCar("Volkswagen Beetle", 2006);
            carport.AddCar("Volkswagen Golf Plus", 2009);
            carport.AddCar("Ford Focus", 2007);
            carport.AddCar("Ford Sierra", 1990);
            carport.AddCar("BMW 650", 2007);
            Console.WriteLine(carport.CarCount);
            Console.WriteLine(new string('-', 30));
            for (int i = 0; i < carport.CarCount; i++)
            {
                Console.WriteLine(carport[i]);
            }

        }
    }
}
