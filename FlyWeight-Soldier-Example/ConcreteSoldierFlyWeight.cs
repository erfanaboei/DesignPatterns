using System;

namespace FlyWeight_Soldier_Example
{
    public class ConcreteSoldierFlyWeight: SoldierFlyWeight
    {
        public override void Render(int x, int y, int z, int number)
        {
            Console.WriteLine($"Soldier Type => {SoldierType} | Show in Location => x: {x} - y: {y} - z: {z} | Soldier Number => {number}");
        }
    }
}