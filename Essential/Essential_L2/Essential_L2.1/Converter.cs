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

        public void CurrencyConverter(Currency currencyFrom, Currency currencyTo, double sum)
        {
            double result;

            if (currencyFrom == Currency.UAH)
            {
                switch (currencyTo)
                {
                    case Currency.USD:
                        Console.WriteLine("{0:N} UAH equals to {1:N} USD", sum, result = (sum / Usd));
                        break;
                    case Currency.EUR:
                        Console.WriteLine("{0:N} UAH equals to {1:N} EUR", sum, result = (sum / Eur));
                        break;
                    case Currency.RUB:
                        Console.WriteLine("{0:N} UAH equals to {1:N} RUB", sum, result = (sum / Rub));
                        break;
                    case Currency.UAH:
                        Console.WriteLine("{0:N} UAH equals to {0:N} UAH", sum);
                        break;
                    default:
                        Console.WriteLine("Error! The program cannot convert UAH to {0}!", currencyTo);
                        break;
                }

            }
            else if (currencyTo == Currency.UAH)
            {
                switch (currencyFrom)
                {
                    case Currency.USD:
                        Console.WriteLine("{0:N} USD equals to {1:N} UAH", sum, result = (sum * Usd));
                        break;
                    case Currency.EUR:
                        Console.WriteLine("{0:N} EUR equals to {1:N} UAH", sum, result = (sum * Eur));
                        break;
                    case Currency.RUB:
                        Console.WriteLine("{0:N} RUB equals to {1:N} UAH", sum, result = (sum * Rub));
                        break;
                    case Currency.UAH:
                        Console.WriteLine("{0:N} UAH equals to {0:N} UAH", sum);
                        break;
                    default:
                        Console.WriteLine("Error! The program cannot convert {0} to UAH!", currencyFrom);
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
