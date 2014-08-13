using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car(Brand.Volkswagen, "New Beetle", 2006, Color.Green),
                new Car(Brand.Volkswagen, "Golf ", 2008, Color.White),
                new Car(Brand.MercedesBenz, "W204 Classic", 2007, Color.Silver),
                new Car(Brand.Ford, "Focus", 2012, Color.Silver),
                new Car(Brand.BMW, "X6", 2008, Color.Green)
            };

            List<Order> orders = new List<Order>
            {
                new Order(Brand.Volkswagen, "New Beetle", "Kostyantyn Kuzin", "+38(093)9652343"),
                new Order(Brand.Ford, "Focus", "Roman Avershyn", "+38(093)8225696"),
                new Order(Brand.Ford, "Focus", "Dmitrii Shevchik", "+38(093)9835268")
            };

            var carOrdersQuery =
                        from car in cars
                        join order in orders
                        on car.Model equals order.Model
                        where car.Model == "New Beetle"
                        select new
                        {
                            Customer = order.Customer,
                            TelephoneNumber = order.TelephoneNumber,
                            CarBrand = order.Brand,
                            Model = order.Model,
                            Year = car.Year,
                            CarColor = car.Color
                        };

            foreach (var item in carOrdersQuery)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}", item.Customer, item.TelephoneNumber, item.CarBrand, item.Model, item.Year, item.CarColor);
            }
        }
    }
}
