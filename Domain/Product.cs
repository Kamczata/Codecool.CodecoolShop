using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Product : BaseModel
    {
        public string Currency { get; set; }
        public decimal DefaultPrice { get; set; }
        public int ProductCategoryId { get; set; }
        public int SupplierId { get; set; }

    }
}
