using System.Collections.Generic;

namespace FlyWeight_Console
{
    public class FlyWeightFactory
    {
        private readonly Dictionary<string, FlyWeight> _flyWeights = new Dictionary<string, FlyWeight>();

        public FlyWeight GetFlyWeight(string key)
        {
            var isExist = _flyWeights.TryGetValue(key, out var result);
            if (!isExist)
                _flyWeights.Add(key, new ConcreteFlyWeight(key));
            return _flyWeights[key];
        }
    }
}