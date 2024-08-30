using System.ComponentModel.DataAnnotations;

namespace SAOnlineMarket.Models
{
    public class Order
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int ProductQuantity { get; set; }
        
        public decimal Grandtotal { get; set; }

    }
}
