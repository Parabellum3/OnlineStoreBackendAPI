using OnlineStoreBackendAPI.DataAccess.Abstracts;

namespace OnlineStoreBackendAPI.Models.DTO;

public abstract class BaseDto
{
    public int Id { get; set; }
    public string Title { get; set; }
}