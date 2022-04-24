namespace AutoMapperExample.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int BarcodeNumber { get; set; }
    }
}
