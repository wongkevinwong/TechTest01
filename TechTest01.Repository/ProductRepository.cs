using System;
using System.Linq;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private static ProductDbContext _dbContext = new ProductDbContext();
        public IQueryable<Product> GetAll
        {
            get
            {
                return _dbContext.Products;
            }
        }

        public Product GetDetail(string slug)
        {
            return _dbContext.Products.SingleOrDefault(p => p.Id.ToString() == slug || p.Slug.Equals(slug, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
