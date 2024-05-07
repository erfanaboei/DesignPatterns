using AbstractFactory_Console.AbstractFactory;

namespace AbstractFactory_Console
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            IAbstractFactory abstractFactory = new ConcreteFactory1();
            var productA1 = abstractFactory.CreateProductA();
            productA1.Execute();
            
            var productB1 = abstractFactory.CreateProductB();
            productB1.Execute();
            
            abstractFactory = new ConcreteProduct2();
            var productA2 = abstractFactory.CreateProductA();
            productA2.Execute();
            
            var productB2 = abstractFactory.CreateProductB();
            productB2.Execute();
        }
    }
}