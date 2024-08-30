namespace SAOnlineMarket.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public decimal Grandtotal { get; set; }

    }
}
