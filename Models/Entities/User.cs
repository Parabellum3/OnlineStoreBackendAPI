using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStoreBackendAPI.Models.Entities;

public class User : BaseModel
{
    [NotMapped]
    public Address Address { get; set; }
    public string? Email { get; set; } 
    public string? PhoneNumber { get; set; }

    public ICollection<Address> Addresses { get; set; }
}
