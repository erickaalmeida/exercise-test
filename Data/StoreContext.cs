using api_main.Entities;
using Microsoft.EntityFrameworkCore;


namespace api_main.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products{get; set;}
    }
}