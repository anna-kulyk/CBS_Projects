using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.ProductA;

namespace AbstractFactoryPattern.ProductB
{
    abstract class AbstractProductB
    {
        abstract public void Interact(AbstractProductA apa);
    }
}
