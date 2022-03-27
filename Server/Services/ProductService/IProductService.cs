using AU.Server.Models;

namespace AU.Server.Services.ProductService
{
    public interface IProductService

    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(long productId);
    }
}
