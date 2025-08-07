namespace B2BOrderManagement.Models.Variant
{
    public class Variant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int ProductId { get; set; }
        public string Sku { get; set; }
    }
}