using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.Models.DTO;

[DataContract]
public class ProductDto
{
    [JsonConstructor]
    public ProductDto(){}
    public ProductDto(Product product)
    {
        Id = product.Id;
        Title = product.Title;
        Price = product.Price; 
        Category = product.Category.Title;
    }

    [DataMember]
    public int Id { get; set; }

    [DataMember] public string Title { get; set; }

    [DataMember] public Dictionary<string, string> Attributes { get; set; }

    [DataMember] public double Price { get; set; }

    [DataMember] public string Category { get; set; }

    [DataMember] public string Description { get; set; }

}

