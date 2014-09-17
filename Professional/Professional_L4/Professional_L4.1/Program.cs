using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Professional_L4._1
{
    /*
     * Задание 3 
     * Напишите шуточную программу «Дешифратор», которая бы в текстовом файле могла бы заменить все предлоги на слово «ГАВ!».
     * (На данный момент замена происходит не в текстовом файле, а в предложении, ввдененном пользователем.)
    */

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[а-я]{1,3}\b";
            string sentence;

            Console.WriteLine("Введите предложение:");
            sentence = Console.ReadLine();

            string result = Regex.Replace(sentence, pattern, "ГАВ!");
            Console.WriteLine(result);
        }
    }
}
