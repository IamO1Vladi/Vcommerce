using Newtonsoft.Json;

namespace Vcommerce.Services.ServiceModels.Product;

public class ClothingFromSessionStorageServiceModel
{
    [JsonProperty("id")] 
    public string ClothingId { get; set; } = null!;

    [JsonProperty("name")]
    public string Name { get; set; } = null!;

    [JsonProperty("imageUrl")]
    public string? ImageUrl { get; set; }

    [JsonProperty("price")]
    public string Price { get; set; } = null!;

    [JsonProperty("quantity")]
    public int Quantity { get; set; }

    [JsonProperty("size")]
    public string Size { get; set; } = null!;
}