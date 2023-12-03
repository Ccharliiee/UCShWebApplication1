using Microsoft.EntityFrameworkCore;
using UCShWebApplication1.Entities;

namespace UCShWebApplication1.DbConnectHelper
{
    public class ProStoreContext : DbContext
    {
        public ProStoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

    }
}
