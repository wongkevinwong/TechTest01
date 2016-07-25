using System.Web.Http;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [Route("api/product/{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            var productsById = _productService.GetById(id);
            if(productsById == null)
            {
                return NotFound();
            }else
            {
                return Ok(productsById);
            }
        }

        [Route("api/products")]
        public IHttpActionResult GetProducts()
        {
            var products = _productService.GetProducts();

            return Ok(products);
        }
    }
}
