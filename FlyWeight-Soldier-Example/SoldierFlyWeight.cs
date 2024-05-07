namespace FlyWeight_Soldier_Example
{
    public abstract class SoldierFlyWeight
    {
        public string SoldierType { get; set; }

        public abstract void Render(int x, int y, int z, int number);

        public void SetSoldierType(string soldierType)
        {
            SoldierType = soldierType;
        }
    }
}