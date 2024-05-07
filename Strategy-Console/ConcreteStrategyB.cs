using System;

namespace Strategy_Console
{
    public class ConcreteStrategyB: Strategy
    {
        public override void LogAnything(string anything)
        {
            Console.WriteLine($"ConcreteStrategyB: {anything}");
        }
    }
}