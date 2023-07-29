using System.ComponentModel.DataAnnotations;
using Vcommerce.Data.Models.Enums;

namespace Vcommerce.Web.ViewModels.Clothes;

using static VCommerce.Common.DataBaseValidations.ProductValidations;
using static VCommerce.Common.DataBaseValidations.ClothesValidations;
using static VCommerce.Common.DataBaseValidations.ProductImagesValidations;


public class ExclusiveProductsViewModel
{

    [Required]
    public Guid Id { get; set; }

    [Required]
    [StringLength(MaxNameLength,MinimumLength = MinNameLength)]
    public string Name { get; set; } = null!;

    [Required]
    [Range(minimum:MinPrice,maximum:MaxPrice)]
    public decimal Price { get; set; }

    [Required]
    public bool IsOnSale { get; set; }

    [Required]
    public bool IsNew { get; set; }

    public bool IsHot { get; set; }

    
    [Range(minimum:MinSalesPercentage,maximum:MaxSalesPercentage)]
    public decimal? SalesPercentage { get; set; }

    [Required]
    [StringLength(MaxUrlLength,MinimumLength = MinUrlLength)]
    public string ImageUrl { get; set; } = null!;

    [Required]
    [StringLength(MaxColorNameLength,MinimumLength = MinColorNameLength)]
    public string Color { get; set; } = null!;

    [Required]
    public Category Category { get; set; }

    [Required]
    public Gender Gender { get; set; }
}