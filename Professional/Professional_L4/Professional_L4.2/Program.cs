using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Professional_L4._2
{
    /*
     * Задание 4 
     * Создайте текстовый файл-чек по типу «Наименование товара – 0.00(цена)грн.» 
     * с определенным количеством наименований товаров и датой совершения покупки. 
     * Выведите на экран информацию из чека в формате текущей локали пользователя и в формате локали en - US.
     */

    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            string path = @"H:\Projects\Labs\Professional\Professional_L4\Чек.txt";

            using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        input += line + "\n";
                        line = sr.ReadLine();
                    }
                }
            }
            if (input != null)
            {
                NumberFormatInfo nfi = CultureInfo.GetCultureInfo("en-US").NumberFormat;
                string currencySymbol = nfi.CurrencySymbol;
                string decimalSeparator = nfi.CurrencyDecimalSeparator;
                CultureInfo dt = CultureInfo.CreateSpecificCulture("en-US");

                NumberFormatInfo nfic = CultureInfo.CurrentCulture.NumberFormat;
                string currencySymbolCurrent = nfic.CurrencySymbol;
                string decimalSeparatorCurrent = nfic.CurrencyDecimalSeparator;

                string pattern = @"(?<numbersBeforeSeparator>\s\b\d+\s?\d*)[.,]?(?<numbersAfterSeparator>\d*\b\s)\S{4}";

                string patternDate = @"\b\d{1,2}\.\d{1,2}\.\d{2,4}\b";
                DateTime date = DateTime.Parse((Regex.Match(input, patternDate)).ToString());

                string replacement = "${numbersBeforeSeparator}" + decimalSeparator + "${numbersAfterSeparator}" + currencySymbol;
                Console.WriteLine("В формате en-US:");
                Console.WriteLine(Regex.Replace(Regex.Replace(input, pattern, replacement), patternDate, date.ToString("MM/dd/yyyy", CultureInfo.CreateSpecificCulture("en-US"))));
                Console.WriteLine();

                string replacementCurrent = "${numbersBeforeSeparator}" + decimalSeparatorCurrent + "${numbersAfterSeparator}" + currencySymbolCurrent;
                Console.WriteLine("В формате текущей локали:");
                Console.WriteLine(Regex.Replace(Regex.Replace(input, patternDate, date.ToShortDateString()), pattern, replacementCurrent));
            }            
        }
    }
}
