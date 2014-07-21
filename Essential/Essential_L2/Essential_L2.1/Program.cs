using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myMoney = new Converter(11.6556, 15.7642, 0.3315);

            myMoney.CurrencyConverter(Currency.USD, Currency.UAH, 100);
            Console.WriteLine(new String('-', 50));
            myMoney.CurrencyConverter(Currency.UAH, Currency.UAH, 100);
            Console.WriteLine(new String('-', 50));
            myMoney.CurrencyConverter(Currency.UAH, Currency.USD, 100);
            Console.WriteLine(new String('-', 50));
            myMoney.CurrencyConverter(Currency.UAH, Currency.RUB, 100);
            Console.WriteLine(new String('-', 50));
            myMoney.CurrencyConverter(Currency.EUR, Currency.UAH, 100);
            Console.WriteLine(new String('-', 50));
            myMoney.CurrencyConverter(Currency.UAH, Currency.EUR, 100);
        }
    }
}
