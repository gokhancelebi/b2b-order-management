namespace B2BOrderManagement.Models.Product
{
    public class ProductXProductAttributeValue
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductAttributeId { get; set; }
        public string Value { get; set; }
    }
}