using Ruby.Leopard.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Ruby.Leopard.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
            { }
        
        public DbSet<Item> Items { get; set; }
    }
}
