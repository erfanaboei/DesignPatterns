using System;

namespace Strategy_Console
{
    public class ConcreteStrategyC: Strategy
    {
        public override void LogAnything(string anything)
        {
            Console.WriteLine($"ConcreteStrategyC: {anything}");
        }
    }
}