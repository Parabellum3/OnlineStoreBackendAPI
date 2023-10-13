
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreBackendAPI.Models.Entities;

public abstract class BaseModel
{
    [Key]
    public int Id { get; set; }

    public string? Title { get; set; } = "";
    public string? Description { get; set; } = "";

}