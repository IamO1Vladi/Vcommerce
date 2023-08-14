using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Vcommerce.Web.ViewModels.Brands;
using static VCommerce.Common.DataBaseValidations.BrandValidations;

public class AddOrEditBrandViewModel
{

    [Required]
    [StringLength(MaxNameLength, MinimumLength = MinNameLength)]
    public string Name { get; set; } = null!;

    [StringLength(MaxDescriptionLength,MinimumLength = MinDescriptionLength)]
    public string? Description { get; set; }

    public IFormFile? Image { get; set; }


}