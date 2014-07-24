using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L5
{
    class Dictionary
    {
        private string[] valueRU = new string[5];
        private string[] valueEN = new string[5];
        private string[] valueUA = new string[5];
        private string[] key;
        private string[] value;

        public Dictionary()
        {
            valueRU[0] = "книга"; valueEN[0] = "book"; valueUA[0] = "книжка";
            valueRU[1] = "ручка"; valueEN[1] = "pen"; valueUA[1] = "ручка";
            valueRU[2] = "солнце"; valueEN[2] = "sun"; valueUA[2] = "сонце";
            valueRU[3] = "яблоко"; valueEN[3] = "apple"; valueUA[3] = "яблуко";
            valueRU[4] = "стол"; valueEN[4] = "table"; valueUA[4] = "стіл";
        }

        public string this[string index, Language from, Language to]
        {
            get
            {
                switch(from)
                {
                    case Language.EN:
                        {
                            key = valueEN;
                            break;
                        }
                    case Language.RU:
                        {
                            key = valueRU;
                            break;
                        }
                    case Language.UA:
                        {
                            key = valueUA;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет перевода с указанного языка"); ;
                            break;
                        }
                }

                switch (to)
                {
                    case Language.EN:
                        {
                            value = valueEN;
                            break;
                        }
                    case Language.RU:
                        {
                            value = valueRU;
                            break;
                        }
                    case Language.UA:
                        {
                            value = valueUA;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет перевода на указанный язык"); ;
                            break;
                        }
                }

                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + value[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < valueRU.Length)
                    return valueRU[index] + " - " + valueEN[index] + " - " + valueUA[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
