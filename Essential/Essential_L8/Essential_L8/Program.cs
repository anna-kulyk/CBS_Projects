using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birthday: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;            
            DateTime nextBirthday = new DateTime(now.Year, birthday.Month, birthday.Day);
            TimeSpan delta;
            if (nextBirthday.DayOfYear <= now.DayOfYear)
            {
                nextBirthday = new DateTime(now.Year + 1, birthday.Month, birthday.Day);
            }
            delta = nextBirthday - now;
            Console.WriteLine((delta.Days + 1) + " day(s) left till your next birthday!");
        }
    }
}
