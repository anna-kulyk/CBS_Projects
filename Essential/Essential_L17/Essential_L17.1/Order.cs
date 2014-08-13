using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L17._1
{
    class Order
    {
        public Order(Brand brand, string model, string customer, string telephoneNumber)
        {
            Brand = brand;
            Model = model;
            Customer = customer;
            TelephoneNumber = telephoneNumber;
        }

        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string Customer { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
