using System;
using System.Collections.Generic;

namespace FlyWeight_Console
{
    internal abstract class Program
    {
        internal static void Main(string[] args)
        {
            FlyWeightFactory factory = new FlyWeightFactory();
            var flyWeight1 = factory.GetFlyWeight("Test1");
            var flyWeight2 = factory.GetFlyWeight("Test2");
            var flyWeight3 = factory.GetFlyWeight("Test1");
            
            flyWeight1.Operation("Extrinsic State 1");
            flyWeight2.Operation("Extrinsic State 2");
            flyWeight3.Operation("Extrinsic State 3");

            UnsharedConcreteFlyWeight unsharedConcreteFlyWeight = new UnsharedConcreteFlyWeight(
                new List<FlyWeight>()
                {
                    factory.GetFlyWeight("Test1"),
                    factory.GetFlyWeight("Test2"),
                    factory.GetFlyWeight("Test3"),
                    factory.GetFlyWeight("Test4"),
                    factory.GetFlyWeight("Test5"),
                });
            
            unsharedConcreteFlyWeight.Operation("Extrinsic UnsharedConcreteFlyWeight");
            
            Console.ReadKey();
        }
    }
}