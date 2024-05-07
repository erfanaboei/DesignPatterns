using System;
using System.Collections.Generic;

namespace Composite_Console.CompositeClass
{
    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }

    public class Composite: Component
    {
        private List<Component> _components = new List<Component>();
        public Composite(string name):base(name)
        {
            
        }
        public Composite(string name, List<Component> components):base(name)
        {
            _components.AddRange(components);
        }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (var component in _components)
            {
                component.Display(depth + 1);
            }
        }
    }

    public class Leaf : Component
    {
        public Leaf(string name):base(name)
        {
            
        }

        public override void Add(Component component)
        {
            throw new System.NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new System.NotImplementedException();
        }
    
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}