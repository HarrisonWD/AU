using System.Security.AccessControl;

namespace AU.Shared.Models
{
    public class CartProductResponse
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ProductTypeId { get; set; }
        public string ProductType { get; set; } = string.Empty;
        public string Image  { get; set; }=string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
