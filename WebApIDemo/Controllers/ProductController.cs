using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.Interfaces;

namespace WebApIDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        [EnableCors("_myAllowSpecificOrigins")]
        [Route("{productId}")]
        public async Task<ActionResult<ProductDetails>> GetProductDetails(int productId)
        {
            try
            {
                var (isProductPresent, productDetails) = await _productService.GetProductDetailsAsync(productId);

                if (isProductPresent)
                {
                    return Ok(productDetails);
                }


                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception occurred" + ex);

                return Problem("Problem", null, 500);
            }
        }
    }
}
