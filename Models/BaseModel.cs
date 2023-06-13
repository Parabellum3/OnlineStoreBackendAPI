using OnlineStoreBackendAPI.DataAccess;
namespace OnlineStoreBackendAPI.Models;

public abstract class BaseModel
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Description { get; set; } = "";
    
}