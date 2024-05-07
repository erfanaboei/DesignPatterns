using System;

namespace AbstractFactory_Console.Services.ProductB
{
    public class ProductB1:IProductB
    {
        public void Execute()
        {
            Console.WriteLine("ProductB1");
        }
    }
}