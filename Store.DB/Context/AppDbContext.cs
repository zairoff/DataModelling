using Microsoft.EntityFrameworkCore;
using Store.Domain;

namespace Store.DB.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<ModelItems> ModelItems { get; set; }
        public DbSet<OutCome> OutComes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StoreBalance> StoreBalances { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
