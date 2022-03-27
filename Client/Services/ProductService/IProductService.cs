namespace AU.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProducts();

        Task<ServiceResponse<Product>> GetProduct(long productId);
    }
}
