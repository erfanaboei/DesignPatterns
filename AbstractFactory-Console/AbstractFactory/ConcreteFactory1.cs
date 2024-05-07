using AbstractFactory_Console.Services.ProductA;
using AbstractFactory_Console.Services.ProductB;

namespace AbstractFactory_Console.AbstractFactory
{
    public class ConcreteFactory1: IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}