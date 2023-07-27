using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static VCommerce.Common.DataBaseValidations.ProductImagesValidations;

namespace Vcommerce.Data.Models;

public class ClothingImages
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(MaxUrlLength)]
    public string ImageUrl { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(RelatedClothing))]
    public Guid ClothingGuid { get; set; }

    public virtual Clothes RelatedClothing { get; set; } = null!;

}