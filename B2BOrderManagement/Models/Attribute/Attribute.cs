namespace B2BOrderManagement.Models.Attribute
{
    public class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AttributeTypeId { get; set; }
        public AttributeType AttributeType { get; set; }
        public List<AttributeValue> AttributeValues { get; set; } = new List<AttributeValue>();
    }
}