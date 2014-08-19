using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Collection<Word>();
            dictionary.Add(new Word("book", "книга", "книжка"));
            dictionary.Add(new Word("pen", "ручка", "ручка"));
            dictionary.Add(new Word("sun", "солнце", "сонце"));
            dictionary.Add(new Word("apple", "яблоко", "яблуко"));
            dictionary.Add(new Word("table", "стол", "стіл"));

            dictionary.TranslationFromUkrainian("яблуко", Language.EN);            
        }
    }
}
