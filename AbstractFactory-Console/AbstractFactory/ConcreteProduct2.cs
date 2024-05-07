using AbstractFactory_Console.Services.ProductA;
using AbstractFactory_Console.Services.ProductB;

namespace AbstractFactory_Console.AbstractFactory
{
    public class ConcreteProduct2: IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}