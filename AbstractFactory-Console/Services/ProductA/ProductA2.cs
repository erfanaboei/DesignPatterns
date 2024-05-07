using System;

namespace AbstractFactory_Console.Services.ProductA
{
    public class ProductA2: IProductA
    {
        public void Execute()
        {
            Console.WriteLine("ProductA2");
        }
    }
}