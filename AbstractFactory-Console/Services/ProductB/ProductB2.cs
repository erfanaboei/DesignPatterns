using System;

namespace AbstractFactory_Console.Services.ProductB
{
    public class ProductB2: IProductB
    {
        public void Execute()
        {
            Console.WriteLine("ProductB2");
        }
    }
}