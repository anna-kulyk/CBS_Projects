using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L2._1
{
    class Converter
    {
        public Converter() { }

        public Converter (double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }

        public double Usd { get; private set; }
        public double Eur { get; private set; }
        public double Rub { get; private set; }

        public void CurrencyConverter(string currencyFrom, string currencyTo, double sum)
        {
            double result;

            if (currencyFrom.ToLower() == "uah")
            {
                switch (currencyTo.ToLower())
                {
                    case "usd":
                        Console.WriteLine("{0:N} UAH equals to {1:N} {2}", sum, result = (sum / Usd),currencyTo.ToUpper());
                        break;
                    case "eur":
                        Console.WriteLine("{0:N} UAH equals to {1:N} {2}", sum, result = (sum / Eur), currencyTo.ToUpper());
                        break;
                    case "rub":
                        Console.WriteLine("{0:N} UAH equals to {1:N} {2}", sum, result = (sum / Rub), currencyTo.ToUpper());
                        break;
                    case "uah":
                        Console.WriteLine("{0:N} UAH equals to {0:N} UAH", sum);
                        break;
                    default:
                        Console.WriteLine("Error! The program cannot convert UAH to {0}!", currencyTo.ToUpper());
                        break;
                }

            }
            else if (currencyTo.ToLower() == "uah")
            {
                switch (currencyFrom.ToLower())
                {
                    case "usd":
                        Console.WriteLine("{0:N} {2} equals to {1:N} UAH", sum, result = (sum * Usd), currencyFrom.ToUpper());
                        break;
                    case "eur":
                        Console.WriteLine("{0:N} {2} equals to {1:N} UAH", sum, result = (sum * Eur), currencyFrom.ToUpper());
                        break;
                    case "rub":
                        Console.WriteLine("{0:N} {2} equals to {1:N} UAH", sum, result = (sum * Rub), currencyFrom.ToUpper());
                        break;
                    case "uah":
                        Console.WriteLine("{0:N} UAH equals to {0:N} UAH", sum);
                        break;
                    default:
                        Console.WriteLine("Error! The program cannot convert {0} to UAH!", currencyFrom.ToUpper());
                        break;
                }

            }
            else
            {
                Console.WriteLine("Error! One of the currencies should be hryvnia!");
            }
        }
    }
}
