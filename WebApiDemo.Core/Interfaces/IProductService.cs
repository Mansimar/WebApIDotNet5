using System.Threading.Tasks;
using WebApiDemo.Core.Entities;

namespace WebApiDemo.Core.Interfaces
{
    public interface IProductService
    {
        Task<(bool, ProductDetails)> GetProductDetailsAsync(int productId);
    }
}
