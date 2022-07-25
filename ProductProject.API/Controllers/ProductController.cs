using Microsoft.AspNetCore.Mvc;
using ProductProject.API.Services;

namespace ProductProject.API.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }
        public IActionResult Get(int Id)
        {
            return Ok(_productService.Get(Id));
        }
    }
}
