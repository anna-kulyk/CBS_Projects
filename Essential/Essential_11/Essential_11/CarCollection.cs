using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_11
{
    class CarCollection<T> where T : Car, new ()
    {
        T[] cars = new T[0];

        public int CarCount
        {
            get
            {
                return cars.Length;
            }
        }

        public void AddCar(string name, uint year)
        {
            Array.Resize<T>(ref cars, (cars.Length + 1));
            cars[cars.Length - 1] = new T();
            cars[cars.Length - 1].Name = name;
            cars[cars.Length - 1].Year = year;

        }

        public void Clear()
        {
            cars = new T[0];
        }

        public string this[int index]
        {
            get
            {
                if (index >=0 && index < cars.Length)
                {
                    return cars[index].ToString();
                }
                else
                {
                   return string.Format("Index is out of range!");
                }
            }
        }
    }
}
