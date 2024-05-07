using AbstractFactory_Console.Services.ProductA;
using AbstractFactory_Console.Services.ProductB;

namespace AbstractFactory_Console.AbstractFactory
{
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}