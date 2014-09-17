using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L4
{
    /*
     * Напишите консольное приложение, позволяющие пользователю зарегистрироваться под «Логином», 
     * состоящем только из символов латинского алфавита , и пароля , состоящего из цифр и символов .
    */

    class Program
    {
        static void Main(string[] args)
        {
            var regexLogin = new Regex(@"^[A-Za-z]+$");
            var regexPassword = new Regex(@"^[A-Za-z0-9]+$");
            bool b = true;
            string login, password;

            while (b)
            {
                Console.Write("Enter Login: ");
                login = Console.ReadLine();

                if (regexLogin.IsMatch(login))
                {
                    break;
                }

                login = null;
                Console.WriteLine("Your login should contain latin letters only! Try again.");
            }

            while (b)
            {
                Console.Write("Enter Password: ");
                password = Console.ReadLine();

                if (regexPassword.IsMatch(password))
                {
                    break;
                }

                password = null;
                Console.WriteLine("Your password should contain only latin letters and digits! Try again.");
            }

            Console.WriteLine("Thank you for your registration!");
            Console.ReadKey();
        }
    }
}
