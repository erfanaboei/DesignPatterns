using System;

namespace FlyWeight_Soldier_Example
{
    internal abstract class Program
    {
        internal static void Main(string[] args)
        {
            var soldierFactory = new SoldierFactory();
            for (var i = 0; i < 1000; i++)
            {
                var soldier = soldierFactory.GetSoldier("sardar");
                soldier.Render(10, 20, 30, i);
            }
            
            Console.ReadKey();
        }
    }
}