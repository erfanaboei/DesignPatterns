using System;

namespace FactoryMethod_Console
{
    public abstract class Product
    {
        public abstract void Execute();
    }

    public class ConcreteProduct1: Product
    {
        public override void Execute()
        {
            Console.WriteLine("ConcreteProduct1.Execute...");
        }
    }

    public class ConcreteProduct2 : Product
    {
        public override void Execute()
        {
            Console.WriteLine("ConcreteProduct2.Execute...");
        }
    }

    public class DefaultProduct : Product
    {
        public override void Execute()
        {
            Console.WriteLine("DefaultProduct.Execute...");
        }
    }
}