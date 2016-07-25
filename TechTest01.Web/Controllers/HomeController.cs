using System.Linq;
using System.Web.Mvc;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Home
        public ActionResult Index()
        {
            var products = _productService.GetProducts().Take(2);
            return View(products);
        }
    }
}