using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using WebApplication1.Dtos;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class notProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public notProductsController(IProductService productService)
        {
            _productService = productService;

        }
        [HttpGet]
        public IActionResult la2read() 
        {
            return Ok(_productService.GetAll());

        }
        [HttpPost]
        public IActionResult la2create(CreateProductDto createProductDto)
        {
            _productService.add(createProductDto);
            return Ok();

        }
        [HttpDelete]
        public IActionResult la2delete(int id)
        {
            _productService.delete(id);
            return Ok();

        }
        [HttpPut]
        public IActionResult la2update(ProductDto ProductDto)
        {
            _productService.update(ProductDto);
            return Ok();
        }



    }
}
