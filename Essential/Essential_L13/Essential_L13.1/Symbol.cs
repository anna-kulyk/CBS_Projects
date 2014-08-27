using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L13._1
{
    class Symbol
    {
        public Symbol(Random r)
        {
            X = 0;
            Y = 0;
            Character = RandomChar(r);
        }

        public int X { get; set; }
        public int Y { get; set; }
        public char Character { get; set; }
        public ConsoleColor Color { get; set; }

        public static char RandomChar(Random r)
        {
            char newChar = (char)r.Next(0x0061, 0x007A);
            return newChar;            
        }
    }
}
