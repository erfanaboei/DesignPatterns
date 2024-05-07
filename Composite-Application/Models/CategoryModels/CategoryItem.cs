using System;

namespace Composite_Application.Models.CategoryModels
{
    public class CategoryItem : CategoryComponent
    {
        public string Link { get; set; }

        public CategoryItem(string name, string link)
        {
            this.Name = name;
            this.Link = link;
        }
        
        public CategoryItem(){}
        
        public override void Add(CategoryComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(CategoryComponent component)
        {
            throw new NotImplementedException();
        }

        public override string Print()
        {
            var li = $"<li><a href='{Link}'>{Name} </a></li>";
            return li;
        }
    }
}