using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Vcommerce.Data.Models.Enums;

namespace Vcommerce.Services.ServiceModels.Filtering;

public class ShopListFilteringServiceModel
{

    

    [JsonProperty("brandId")]
    public string[] BrandId { get; set; } = new string[30];

    [JsonProperty("Gender")]
    public Gender Gender { get; set; }

    [JsonProperty("Category")]
    public Category Category { get; set; }

}