using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// https://chatgpt.com/c/6894e009-7c5c-832e-812f-eac445a2de37

namespace B2BOrderManagement.Models.Attribute
{
    public enum AttributeType
    {
        [EnumMember(Value = "selectbox")]
        SelectBox,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "textbox")]
        TextBox,
        [EnumMember(Value = "textarea")]
        TextArea,
        [EnumMember(Value = "numberbox")]
        NumberBox,
        [EnumMember(Value = "datebox")]
        DateBox,
    }
    public class ProductAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AttributeType AttributeType { get; set; }
    }
}