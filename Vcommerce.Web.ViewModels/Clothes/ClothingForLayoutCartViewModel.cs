using Newtonsoft.Json;

namespace Vcommerce.Web.ViewModels.Clothes;

public class ClothingForLayoutCartViewModel
{

   
    public Guid ClothingId { get; set; }

    
    public string Name { get; set; } = null!;

    
    public string? ImageUrl { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public string Size { get; set; } = null!;

}