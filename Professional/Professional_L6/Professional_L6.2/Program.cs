using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Celsius: ");
            decimal temprC = 0;
            decimal temprF = 0;
            Assembly assembly = null;

            try
            {
                temprC = Convert.ToDecimal(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                assembly = Assembly.Load("Temperature");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (assembly != null)
            {
                var type = assembly.GetType("Temperature.Temperature");
                var method = type.GetMethod("ConvertToFahrenheit", BindingFlags.Static | BindingFlags.Public);
                temprF = (decimal)method.Invoke(null, new object []{ temprC });                
            }
            

            Console.WriteLine("The temperature in Fahrenheit is: " + temprF);
        }
    }
}
