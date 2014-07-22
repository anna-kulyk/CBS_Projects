using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInvoice = new Invoice(2356456648529637, "Anna", "Walmart");
            myInvoice.NewOrder(Article.Cucumber, 2, 1, VAT.VAT_20);
        }
    }
}
