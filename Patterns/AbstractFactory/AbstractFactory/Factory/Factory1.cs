using System;
using AbstractFactoryPattern.ProductA;
using AbstractFactoryPattern.ProductB;

namespace AbstractFactoryPattern.Factory
{
    class Factory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
