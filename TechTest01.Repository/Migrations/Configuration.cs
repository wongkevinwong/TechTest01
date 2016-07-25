namespace TechTest01.Repository.Migrations
{
    using Domain.Catalog;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<TechTest01.Repository.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TechTest01.Repository.ProductDbContext context)
        {
            context.Products.AddOrUpdate(
             p => p.Slug,
             new Product { Id = 1, Name = "T-shirt", Slug = "T-shirt", Description = "desc 1", Price = 10.50M, ImageUrl = "" },
             new Product { Id = 2, Name = "Safety boot", Slug = "Safety boot", Description = "desc 2", Price = 20.00M, ImageUrl = "" },
             new Product { Id = 3, Name = "Black hat", Slug = "Black hat", Description = "desc 3", Price = 30.00M, ImageUrl = "" },
             new Product { Id = 4, Name = "Red hat", Slug = "Red hat", Description = "desc 4", Price = 50.00M, ImageUrl = "" }
           );
        }
    }
}
