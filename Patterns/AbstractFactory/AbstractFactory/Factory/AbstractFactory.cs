using System;
using AbstractFactoryPattern.ProductA;
using AbstractFactoryPattern.ProductB;

namespace AbstractFactoryPattern.Factory
{
    abstract class AbstractFactory
    {
        abstract public AbstractProductA CreateProductA();
        abstract public AbstractProductB CreateProductB();
    }
}
