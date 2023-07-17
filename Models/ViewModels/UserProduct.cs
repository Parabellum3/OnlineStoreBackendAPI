using OnlineStoreBackendAPI.Models.DTO;

namespace OnlineStoreBackendAPI.Models.ViewModels;

public class UserProduct : BaseModel
{
    public User User { get; private set; }

    public Product Product { get; private set; }

    public int Quantity { get; set; }
}