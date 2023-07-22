using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using OnlineStoreBackendAPI.Models.DTO;

namespace OnlineStoreBackendAPI.Models.ViewModels;

public class Product : BaseModel
{
    public double Price { get; set; }
    public  Category Category { get; set; }
    
    public int CategoryId { get; set; }
    public ICollection<AttributeValue> AttributeValues { get; set; }
}