using System.Linq;
using Composite_Application.Models.CategoryModels;
using Composite_Application.Models.ProductModels;
using DesignPatterns.Context;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    public class CompositeController : Controller
    {
        private readonly DesignPatternContext _context;

        public CompositeController(DesignPatternContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var menus = _context.CategoryComponents.ToList();
            var result = "";

            foreach (var menu in menus.Where(r=>r.GetType() == typeof(Category)))
            {
                // _context.Products.Add(new Product()
                // {
                //     Name = "test",
                //     CategoryItem = menu as CategoryItem,
                // });
                // _context.SaveChanges();
                result += menu.Print();
            }

            return View("Index", result);
        }

        [HttpPost]
        public IActionResult AddCategories()
        {
            var mainCategory = new Category("محصولات");
            mainCategory.Add(new CategoryItem("موبایل", "Mobile"));
            mainCategory.Add(new CategoryItem("لپ تاپ", "Laptop"));
            mainCategory.Add(new CategoryItem("کتاب", "Book"));

            _context.Add(mainCategory);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}