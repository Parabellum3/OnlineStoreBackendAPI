using System.Xml.Linq;
using OnlineStoreBackendAPI.Models.DTO;

namespace OnlineStoreBackendAPI.Models.ViewModels;

public class Product : BaseModel
{
    public double Price { get; set; } = 0;
    public Category Category { get; set; }

    public List<AttributeValue> AttributeValues { get; set; }
}