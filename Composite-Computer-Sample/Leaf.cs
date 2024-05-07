using System;

namespace Composite_Computer_Sample
{
    public class Leaf : IComponent
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Leaf(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
        
        public int DisplayPrice()
        {
            Console.WriteLine(Name + ":" + Price);
            return Price;
        }
    }
}