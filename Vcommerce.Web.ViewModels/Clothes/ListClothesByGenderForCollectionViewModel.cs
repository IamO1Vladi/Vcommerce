using Vcommerce.Data.Models.Enums;

namespace Vcommerce.Web.ViewModels.Clothes;

public class ListClothesByGenderForCollection
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public decimal Price { get; set; }

    public Gender Gender { get; set; }
}