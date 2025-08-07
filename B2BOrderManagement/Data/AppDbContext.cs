using Microsoft.EntityFrameworkCore;
using B2BOrderManagement.Models.User;
using B2BOrderManagement.Models.Product;
using B2BOrderManagement.Models.Category;
using B2BOrderManagement.Models.Attribute;
using B2BOrderManagement.Models.TaxClass;
using B2BOrderManagement.Models;
using B2BOrderManagement.Models.Order;
using B2BOrderManagement.Models.Variant;

namespace B2BOrderManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public DbSet<TaxClass> TaxClasses { get; set; }
        public DbSet<WebsiteOption> WebsiteOptions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<VariantAttributeValue> VariantAttributeValues { get; set; }
    }
}
