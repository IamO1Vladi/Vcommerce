using System.ComponentModel.DataAnnotations;
using Vcommerce.Data.Models.Enums;
using static VCommerce.Common.DataBaseValidations.ClothesValidations;

namespace Vcommerce.Data.Models;

public class Clothes:Product
{
    public Clothes()
    {
        this.Id = new Guid();
        this.Images = new HashSet<ProductImages>();
        this.DateCreated= DateTime.UtcNow;
    }

    [Required]
    [MaxLength(MaxMaterialNameLength)]
    public string Material { get; set; } = null!;

    [Required]
    public ClothesSizes Size { get; set; }

    [Required]
    public Category Category { get; set; }

    [Required]
    public Gender Gender { get; set; }

    
}