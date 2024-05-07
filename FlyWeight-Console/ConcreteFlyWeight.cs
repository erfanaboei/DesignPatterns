using System;

namespace FlyWeight_Console
{
    public class ConcreteFlyWeight: FlyWeight
    {
        private readonly string _intrinsicState;

        public ConcreteFlyWeight(string intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }
        
        public override void Operation(string extrinsicState)
        {
            Console.WriteLine($"Intrinsic State => {_intrinsicState} ---- Extrinsic State => {extrinsicState}");
        }
    }
}