namespace Vcommerce.Web.ViewModels.Brands;

public class ListAllBrandsViewModel
{

    public string Name { get; set; } = null!;

    public Guid BrandId { get; set; }

    public string? Description { get; set; } 

    public string? LogoUrl { get; set; }
}