using System;

namespace AbstractFactory_Console.Services.ProductA
{
    public class ProductA1: IProductA
    {
        public void Execute()
        {
            Console.WriteLine("ProductA1");
        }
    }
}