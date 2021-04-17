using System.Threading.Tasks;
using WebApiDemo.Core.Entities;

namespace WebApiDemo.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductDetails> GetProductDetailsAsync(int productId);
    }
}
