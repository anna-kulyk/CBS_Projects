using System;
using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl = null;

            cl = new Client(new Factory1());
            cl.Run();

            cl = new Client(new Factory2());
            cl.Run();
        }
    }
}
