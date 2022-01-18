using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Product : BaseModel
    {
        [Required]
        [MaxLength(10)]
        public string Currency { get; set; }
        public decimal DefaultPrice { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public Supplier Supplier { get; set; }

    }
}
