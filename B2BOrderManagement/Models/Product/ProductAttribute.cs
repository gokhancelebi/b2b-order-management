namespace B2BOrderManagement.Models.Product
{
    public class ProductAttribute
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public bool IsVariationOption { get; set; }
    }
}