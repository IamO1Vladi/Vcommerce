using Microsoft.AspNetCore.Http.Connections;
using Vcommerce.Data.Models.Enums;

namespace Vcommerce.Services.ServiceModels.Product;

public class ClothingSizeServiceModel
{
    
    public ClothesSizes Size { get; set; }

    public int AvailableQuantity { get; set; }

}