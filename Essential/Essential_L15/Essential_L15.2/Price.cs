using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L15._2
{
    struct Price
    {
        private string _product;
        private string _store;
        private double _price;

        public Price(string product, string store, double price)
        {
            _price = 0;
            _product = product;
            _store = store;
            ProductPrice = price;
        }

        public string Product { get { return _product; } }
        public string Store { get { return _store; } }
        public double ProductPrice
        {
            get
            {
                return _price;
            }

            set
            {
                if (value < 0)
                {
                    throw new NegativePriceException();
                }

                _price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - ${2:N}", Product, Store, ProductPrice);
        }
    }
}
