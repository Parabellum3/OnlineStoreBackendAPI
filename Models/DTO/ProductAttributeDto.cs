namespace OnlineStoreBackendAPI.Models.DTO;

public class ProductAttributeDto : BaseDto
{
    public int CategoryId { get; set; }
    
    public string DefValue { get; set; }
}