namespace AU.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;

        Task AddToCard(CartItem cartItem);
        Task<List<CartProductResponse>> GetCartProducts();
        Task<List<CartItem>> GetCartItems();

        Task RemoveProductFromCart(int productId, int productTypeId);

        Task UpdateQuantity(CartProductResponse product);
    }
}
