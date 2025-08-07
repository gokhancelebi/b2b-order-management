using Microsoft.EntityFrameworkCore;
using B2BOrderManagement.Models.User;

namespace B2BOrderManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
        public DbSet<User> Users { get; set; }
    }
}
