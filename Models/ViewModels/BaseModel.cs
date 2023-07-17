namespace OnlineStoreBackendAPI.Models.ViewModels;

public abstract class BaseModel
{
    public int Id { get; set; }

    public string Title { get; set; } 
    public string Description { get; set; }
    
}