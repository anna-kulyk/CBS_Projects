using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accountant.AskForBonus(Post.Programer, 188));
            Console.WriteLine(Accountant.AskForBonus(Post.Manager, 176));
        }
    }
}
