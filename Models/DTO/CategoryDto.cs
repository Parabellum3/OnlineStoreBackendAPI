using System.Text.Json.Serialization;
using OnlineStoreBackendAPI.Models.Entities;

namespace OnlineStoreBackendAPI.Models.DTO;

public class CategoryDto : BaseDto
{
    [JsonConstructor]
    public CategoryDto(){}

    public CategoryDto(Category category)
     {
         Id = category.Id;
         Title = category.Title;
         Description = category.Description;
         if (category.ParentCategory != null) ParentCategory = new CategoryDto(category.ParentCategory);
     }
    public string Description { get; set; }
    public CategoryDto ParentCategory { get; set; }


}