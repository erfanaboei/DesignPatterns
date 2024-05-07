using System;

namespace Strategy_Console
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var fullName = "Erfan Aboei";
            var context = new Context(new ConcreteStrategyA());
            context.LogFullName(fullName);

            context = new Context(new ConcreteStrategyB());
            context.LogFullName(fullName);

            context = new Context(new ConcreteStrategyC());
            context.LogFullName(fullName);
            
            Console.WriteLine("Hello World!");
        }
    }
}