using Composite_Application.Models;
using Composite_Application.Models.CategoryModels;
using Composite_Application.Models.ProductModels;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Context
{
    public class DesignPatternContext:DbContext
    {
        public DesignPatternContext(DbContextOptions options):base(options)
        {
            
        }
        
        //Composite Tables
        public DbSet<CategoryComponent> CategoryComponents { get; set; }
        private DbSet<Category> Categories { get; set; }
        private DbSet<CategoryItem> CategoryItems { get; set; }
        public DbSet<Product> Products { get; set; }
        //Composite Tables

    }
}