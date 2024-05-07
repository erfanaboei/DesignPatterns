using System.Collections.Generic;

namespace FlyWeight_Soldier_Example
{
    public class SoldierFactory
    {
        private Dictionary<string, SoldierFlyWeight> _soldierFlyWeights = new Dictionary<string, SoldierFlyWeight>();

        public SoldierFlyWeight GetSoldier(string key)
        {
            var isExist = _soldierFlyWeights.TryGetValue(key, out var result);

            if (isExist) return _soldierFlyWeights[key];
            
            var soldier = new ConcreteSoldierFlyWeight();
            soldier.SetSoldierType(key);
            _soldierFlyWeights.Add(key, soldier);

            return _soldierFlyWeights[key];
        }
        
    }
}