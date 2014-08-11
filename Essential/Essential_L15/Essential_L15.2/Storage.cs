using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L15._2
{
    class Storage
    {
        private Price[] _storage;

        public Storage(uint n)
        {
            _storage = new Price[n];
            Initialize(_storage);
            Array.Sort(_storage, new Comparison<Price>((a, b) => a.Store.CompareTo(b.Store)));
        }

        private void Initialize(Price[] storage)
        {
            for (int i = 0; i < storage.Length; i++)
            {
                Console.Write("Enter the name of the product: ");
                string productName = Console.ReadLine();
                Console.Write("Enter the name of the store: ");
                string productStore = Console.ReadLine();
                double productPrice = 0;
                bool locker = true;
                while (locker)
                {
                    locker = false;
                    Console.Write("Enter the product price: ");
                    try
                    {
                        productPrice = Convert.ToDouble(Console.ReadLine(), new CultureInfo("en-US"));
                        storage[i] = new Price(productName, productStore, productPrice);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        locker = true;
                    }
                    catch (NegativePriceException e)
                    {
                        Console.WriteLine(e.Message);
                        locker = true;
                    }  
                } 
                Console.Clear();
            }
        }

        public void ShowProductsInStore()
        {
            Console.Write("To find products, enter the name of the store: ");
            string pStore = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < _storage.Length; i++)
            {
                if (pStore.ToLower() == _storage[i].Store.ToLower())
                {
                    Console.WriteLine(_storage[i].ToString());
                    counter++;
                }
            }

            if (counter == 0)
            {
                throw new StoreAbsenceException();
            }
        }

        public Price this[uint index]
        {
            get
            {
                return _storage[index];
            }
        }
    }
}
