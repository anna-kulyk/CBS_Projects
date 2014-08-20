using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L._2._1
{
    class Program
    {
        static IEnumerable<string> GetProductCategoriesByCustomers(NameValueCollection collection, string customer)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection.GetKey(i) == customer)
                {
                    yield return collection.Get(i);
                }
            }
        }

        static IEnumerable<string> GetCustomersByProductCategories(NameValueCollection collection, ProductСategory productCategory)
        {
            string pc = productCategory.ToString();
            for (int i = 0; i < collection.Count; i++)
            {
                for (int j = 0; j < collection.GetValues(i).Length; j++)
                {
                    if (collection.GetValues(i)[j] == pc)
                    {
                        yield return collection.GetKey(i);
                    }
                }                
            }
        }


        static void Main(string[] args)
        {
            var purchase = new NameValueCollection();

            purchase.Add("Kulyk", ProductСategory.Grocery.ToString());
            purchase.Add("Kulyk", ProductСategory.Clothing.ToString());
            purchase.Add("Kulyk", ProductСategory.Sports.ToString());
            purchase.Add("Kuzin", ProductСategory.Grocery.ToString());
            purchase.Add("Kuzin", ProductСategory.Sports.ToString());
            purchase.Add("Kuzin", ProductСategory.Household.ToString());
            purchase.Add("Kuzin", ProductСategory.Furniture.ToString());
            purchase.Add("Kovalenko", ProductСategory.Grocery.ToString());
            purchase.Add("Kovalenko", ProductСategory.Toys.ToString());
            purchase.Add("Kovalenko", ProductСategory.Pharmacy.ToString());
            
            for (int i = 0; i < purchase.Count; i++)
            {
                Console.WriteLine("{0} - {1}", purchase.GetKey(i), purchase.Get(i));
            }
            Console.WriteLine(new string('-', 50));

            var pc = GetProductCategoriesByCustomers(purchase, "Kulyk");
            foreach (var item in pc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));

            var c = GetCustomersByProductCategories(purchase, ProductСategory.Grocery);
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
