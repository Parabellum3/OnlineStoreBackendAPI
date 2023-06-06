namespace OnlineStoreBackendAPI.Models;

public class BaseProduct : BaseModel
{
    public double Price { get; set; }
    public int Quantity { get; set; }
    public  Category Category { get; set; }
}