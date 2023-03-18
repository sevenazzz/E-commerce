namespace E_commerce.Entities
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Orders Order { get; set; }
        public int OrderId { get; set; }
        public Products Product { get; set; }
        public int ProductId { get; set; }
    }
}
