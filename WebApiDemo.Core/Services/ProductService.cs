using System.Threading.Tasks;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.Interfaces;

namespace WebApiDemo.Core
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<(bool, ProductDetails)> GetProductDetailsAsync(int productId)
        {
            var productPresent = true;

            var productDetails = await _productRepository.GetProductDetailsAsync(productId);

            if (productDetails == null)
            {
                productPresent = false;
            }

            return (productPresent, productDetails);
        }
    }
}
