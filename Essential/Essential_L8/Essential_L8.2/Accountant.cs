using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L8._2
{
    static class Accountant
    {
        static public bool AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
