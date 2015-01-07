using System;
using AbstractFactoryPattern.ProductA;
using AbstractFactoryPattern.ProductB;

namespace AbstractFactoryPattern.Factory
{
    class Factory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
