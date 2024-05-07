using System.Collections.Generic;

namespace Composite_Application.Models.CategoryModels
{
    public class Category : CategoryComponent
    {
        private readonly List<CategoryComponent> _menuComponent = new List<CategoryComponent>();

        public ICollection<CategoryComponent> MenuItems => _menuComponent;

        public Category(string name)
        {
            this.Name = name;
        }
        public Category() { }

        public override void Add(CategoryComponent component)
        {
            _menuComponent.Add(component);
        }

        public override void Remove(CategoryComponent component)
        {
            _menuComponent.Remove(component);
        }

        public override string Print()
        {
            var output = $"<ul> {Name}";
            foreach (var categoryComponent in _menuComponent)
            {
                output += categoryComponent.Print();
            }
            output += "</ul>";
            return output;
        }
    }
}