using OnlineStoreBackendAPI.DataAccess.Abstracts;
using OnlineStoreBackendAPI.Models.DTO;

namespace OnlineStoreBackendAPI.Models.ViewModels;

public class CartProduct : BaseModel
{
    public Cart Cart { get;  set; }
    public Product Product { get;  set; }
    public int Quantity { get; set; }
    
    public double Total { get; set; }
}