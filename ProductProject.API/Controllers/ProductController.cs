using Microsoft.AspNetCore.Mvc;
using ProductProject.API.Dto;
using ProductProject.API.Models;
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
        [HttpPost]
        public IActionResult Create([FromBody]CreateDto dto )
        {
            return Ok(_productService.Create(dto));
        }
        [HttpPut]
        public IActionResult Update([FromBody] UpdateDto dto)
        {
            return Ok(_productService.Update(dto));
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _productService.Delete(Id);
            return Ok("Deleted");
        }
    }
}
