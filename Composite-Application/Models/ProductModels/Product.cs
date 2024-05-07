using Composite_Application.Models.CategoryModels;

namespace Composite_Application.Models.ProductModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryItemId { get; set; }
        public CategoryItem CategoryItem { get; set; }
    }
}