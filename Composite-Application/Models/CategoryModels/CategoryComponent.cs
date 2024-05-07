namespace Composite_Application.Models.CategoryModels
{
    public abstract class CategoryComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string Print()
        {
            return "";
        }

        public abstract void Add(CategoryComponent component);
        public abstract void Remove(CategoryComponent component);
    }
}