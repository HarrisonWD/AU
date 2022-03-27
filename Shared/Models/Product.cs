using System.ComponentModel.DataAnnotations.Schema;

namespace AU.Shared.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Image { get; set; } = String.Empty;
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();

    }
}
