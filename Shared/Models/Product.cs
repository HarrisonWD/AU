using System.ComponentModel.DataAnnotations.Schema;

namespace AU.Shared.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Image { get; set; } = String.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        
    }
}
