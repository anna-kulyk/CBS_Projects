using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L2._3
{
    class Invoice
    {
        private readonly ulong _account;
        private readonly string _customer;
        private readonly string _provider;

        public Invoice(ulong account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }

        public ulong Account
        {
            get { return _account; }
        }
        public string Customer
        {
            get { return _customer; }
        }
        public string Provider
        {
            get { return _provider; }
        }

        public void NewOrder(Article article, double quantity, double pricePerPound, VAT vat)
        {
            if (quantity < 0 || pricePerPound < 0)
            {
                Console.WriteLine("Warning! Price and quantity shouldn't be negative.");
            }
            else
            {
                Console.WriteLine("INVOICE{0}{0}Account: {2}{0}Customer: {3}{0}Provider: {4}{0}{1}{0}ORDER:{0}Article: {5}{0}Quantity: {6} lb{0}Price per pound: {7:N} ${0}{1}",
                                   Environment.NewLine,
                                   new String('-', 40),
                                   Account,
                                   Customer,
                                   Provider,
                                   article,
                                   quantity,
                                   pricePerPound);

                if (vat == VAT.VAT_0)
                {
                    Console.WriteLine("Total sum: {0:N} $ VAT not included", (quantity * pricePerPound));
                }
                else if (vat == VAT.VAT_20)
                {
                    Console.WriteLine("Total sum: {0:N} $ VAT included", ((quantity * pricePerPound) * 1.2));
                }
            }
        }
    }
}
