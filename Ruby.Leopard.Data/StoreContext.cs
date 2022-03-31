using Ruby.Leopard.Domain.Catalog;
using Ruby.Leopard.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Ruby.Leopard.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
            { }
        
        public DbSet<Item> Items { get; set; }

        public DbSet<OrderItem> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}
