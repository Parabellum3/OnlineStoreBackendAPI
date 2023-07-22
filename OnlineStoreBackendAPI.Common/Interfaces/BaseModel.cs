
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace OnlineStoreBackendAPI.Models.ViewModels;

public abstract class BaseModel
{
    [Key]
    public int Id { get; set; }
    
    public string Title { get; set; }
    public string? Description { get; set; }

}