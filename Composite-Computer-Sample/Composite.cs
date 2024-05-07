using System;
using System.Collections.Generic;

namespace Composite_Computer_Sample
{
    public class Composite : IComponent
    {
        public string Name { get; set; }
        public int Price { get; set; }
        private List<IComponent> _components = new List<IComponent>();

        public Composite(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
        
        public void AddComponent(IComponent component)
        {
            _components.Add(component);
        }
        
        public int DisplayPrice()
        {
            var totalPrice = Price;
            foreach (var component in _components)
            {
                totalPrice += component.DisplayPrice();
            }
            Console.WriteLine(Name + ":" + totalPrice);
            return totalPrice;
        }
    }
}