using System;

namespace Strategy_Console
{
    public class ConcreteStrategyA: Strategy
    {
        public override void LogAnything(string anything)
        {
            Console.WriteLine($"ConcreteStrategyA: {anything}");
        }
    }
}