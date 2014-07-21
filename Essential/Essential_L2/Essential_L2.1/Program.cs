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

            myMoney.CurrencyConverter("usd", "uah", 100);
            Console.WriteLine(new String('-', 50));
            myMoney.CurrencyConverter("uah", "uah", 100);
            Console.WriteLine(new String('-', 50));
            myMoney.CurrencyConverter("uah", "usd", 100);
            Console.WriteLine(new String('-', 50));
            myMoney.CurrencyConverter("uah", "rub", 100);
            Console.WriteLine(new String('-', 50));
            myMoney.CurrencyConverter("eur", "uah", 100);
            Console.WriteLine(new String('-', 50));
            myMoney.CurrencyConverter("uah", "evr", 100);
        }
    }
}
