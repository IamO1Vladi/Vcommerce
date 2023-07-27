using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vcommerce.Data.Models;
using static VCommerce.Common.DataBaseValidations.ProductValidations;

public abstract class Product
{
    

    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(MaxNameLength)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(MaxBrandLength)]
    public string Brand { get; set; } = null!;

    [Required]
    public decimal Price { get; set; }

    [Required]
    [MaxLength(MaxColorNameLength)]
    public string Color { get; set; } = null!;

    [Required]
    [MaxLength(MaxDescriptionLength)]
    public string Description { get; set; } = null!;

    [Required]
    [Range(minimum:MinQuantity,maximum:MaxQuantity)]
    public int Quantity { get; set; }

    [Required]
    public DateTime DateCreated { get; set; }

    [Required]
    public bool IsNew { get; set; }

    [Required]
    public bool IsOnSale { get; set; }

    public decimal? SalePercentage { get; set; }

    [Required]
    public int NumberOfSales { get; set; }
    public ICollection<ClothingImages> Images { get; set; } = null!;
}