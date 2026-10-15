namespace StoreFlow.Entities
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int SaleCount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
