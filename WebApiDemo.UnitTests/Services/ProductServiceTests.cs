using Moq;
using System.Threading.Tasks;
using WebApiDemo.Core;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.Interfaces;
using Xunit;

namespace WebApiDemo.UnitTests
{
    public class ProductServiceTests
    {
        private static readonly Mock<IProductRepository> _mockProductRepository = new Mock<IProductRepository>();

        [Fact]
        public async Task GetProductDetailsAsync_Success()
        {
            //Arrange
            _mockProductRepository.Setup(x => x.GetProductDetailsAsync(It.IsAny<int>())).Returns(Task.FromResult(new ProductDetails()));
            var productService = new ProductService(_mockProductRepository.Object);

            //Act
            var (isProductPresent, productDetails) = await productService.GetProductDetailsAsync(It.IsAny<int>());

            //Assert
            Assert.True(isProductPresent);
            Assert.NotNull(productDetails);
        }

        [Fact]
        public async Task GetProductDetailsAsync_Failure()
        {
            //Arrange
            _mockProductRepository.Setup(x => x.GetProductDetailsAsync(It.IsAny<int>()));
            var productService = new ProductService(_mockProductRepository.Object);

            //Act
            var (isProductPresent, productDetails) = await productService.GetProductDetailsAsync(It.IsAny<int>());

            //Assert
            Assert.False(isProductPresent);
            Assert.Null(productDetails);
        }
    }
}
