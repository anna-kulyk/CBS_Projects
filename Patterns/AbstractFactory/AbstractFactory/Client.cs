using System;
using AbstractFactoryPattern.ProductA;
using AbstractFactoryPattern.ProductB;
using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern
{
    class Client
    {
        private AbstractProductA apa = null;
        private AbstractProductB apb = null;

        public Client(AbstractFactory af)
        {
            apa = af.CreateProductA();
            apb = af.CreateProductB();
        }

        public void Run()
        {
            this.apb.Interact(this.apa);
        }
    }
}
