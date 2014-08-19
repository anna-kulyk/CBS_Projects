using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1._3
{
    class Word
    {
        public Word(string wordEN, string wordRU, string wordUA)
        {
            WordEN = wordEN;
            WordRU = wordRU;
            WordUA = wordUA;
        }

        public string WordEN { get; private set; }
        public string WordRU { get; private set; }
        public string WordUA { get; private set; }
    }
}
