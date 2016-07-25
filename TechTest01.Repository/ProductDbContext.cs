using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext():base("ProductsDB")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Product> Products { get; set; }
    }
}
