using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Essential_L13._1
{
    class Chain
    {        
        private Random _random = new Random();
        private Symbol[] _symbolChain;

        public Chain()
        {
            _symbolChain = CreateChain();
            Length = _symbolChain.Length;
        }

        public int Length { get; private set; }

        private Symbol[] CreateChain()
        {
            var r = _random.Next(6, 11);
            Symbol[] symbolChain = new Symbol[r];
            
            for (int i = 0; i < r; i++)
            {
                symbolChain[i] = new Symbol(_random);
                symbolChain[i].Y = (- i);

                if (i == 0)
                {
                    symbolChain[i].Color = ConsoleColor.White;
                }
                else if (i == 1)
                {
                    symbolChain[i].Color = ConsoleColor.Green;
                }
                else
                {
                    symbolChain[i].Color = ConsoleColor.DarkGreen;
                }
            }
            return symbolChain;
        }

        public Symbol this[int index]
        {
            get { return _symbolChain[index]; }
        }

    }
}
