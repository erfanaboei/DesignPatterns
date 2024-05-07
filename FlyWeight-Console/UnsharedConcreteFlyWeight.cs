using System;
using System.Collections.Generic;

namespace FlyWeight_Console
{
    public class UnsharedConcreteFlyWeight: FlyWeight
    {
        private List<FlyWeight> _flyWeights;

        public UnsharedConcreteFlyWeight(List<FlyWeight> flyWeights)
        {
            _flyWeights = flyWeights;
        }
        
        public override void Operation(string extrinsicState)
        {
            Console.WriteLine("----- UnsharedConcreteFlyWeight ------");
            
            foreach (var flyWeight in _flyWeights)
            {
                flyWeight.Operation(extrinsicState);
            }
        }
    }
}