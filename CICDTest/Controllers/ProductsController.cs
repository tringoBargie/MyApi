using Microsoft.AspNetCore.Mvc;

namespace CICDTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private static List<string> _products = new()
        {
            "Laptop", "Mouse", "Keyboard"
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_products);
        }

        [HttpPost]
        public IActionResult Add(string product)
        {
            _products.Add(product);
            return Ok($"Added {product}");
        }

    }
}
