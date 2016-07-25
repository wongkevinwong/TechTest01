using System.Collections.Generic;
using System.Linq;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;

namespace TechTest01.Services.Catalog
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        
        public Product GetById(int id)
        {
            return _productRepository.GetDetail(id.ToString());
        }
        
        public ICollection<Product> GetProducts()
        {
            return _productRepository.GetAll.ToList();
        }
    }
}
