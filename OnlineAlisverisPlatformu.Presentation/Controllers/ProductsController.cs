using Microsoft.AspNetCore.Mvc;
using OnlineAlisverisPlatformu.DataAccess.Entities;
using OnlineAlisverisPlatformu.Presentation.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAlisverisPlatformu.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("restricted")]
        [TimeRestrictedAccessFilter(9, 17)]
        public IActionResult GetRestrictedProducts()
        {
            return Ok("Bu endpoint'e yalnızca 09:00 - 17:00 saatleri arasında erişebilirsiniz.");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _productService.AddProductAsync(product);
            return Ok("Ürün başarıyla oluşturuldu.");
        }
    }
}
