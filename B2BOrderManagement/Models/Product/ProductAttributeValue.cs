namespace B2BOrderManagement.Models.Product
{
    public class ProductAttributeValue
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public int AttributeValueId { get; set; }
    }
}