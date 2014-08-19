using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1._3
{
    static class CollectionGenericWordExtensions
    {
        public static Word FindWord(this Collection<Word> words, string word)
        {
            Word result = null;

            foreach (var item in words)
            {
                if (item.WordEN == word || item.WordRU == word || item.WordUA == word)
                {
                    result = item;
                }
            }

            return result;
        }

        public static void TranslationFromUkrainian(this Collection<Word> words, string wordUA, Language to)
        {
            Word theWord = words.FindWord(wordUA);
            string translation = null;
            if (theWord != null)
            {                
                switch (to)
                {
                    case Language.EN:
                        {
                            translation = theWord.WordEN;
                            break;
                        }
                    case Language.RU:
                        {
                            translation = theWord.WordRU;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You can translate the word only to English or Russian!");
                            break;
                        }
                }
                if (translation != null)
                {
                    Console.WriteLine("{0} - {1}", theWord.WordUA, translation);
                }                
            }
            else
            {
                Console.WriteLine("There is no translation for this word!");
            }
        }
    }
}
