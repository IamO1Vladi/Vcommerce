using System.ComponentModel.DataAnnotations;
using Vcommerce.Data.Models.Enums;
using static VCommerce.Common.DataBaseValidations.ClothesValidations;

namespace Vcommerce.Data.Models;

public class Clothes:Product
{
    public Clothes()
    {
        this.Id = Guid.NewGuid();
        this.Images = new HashSet<ClothingImages>();
        this.DateCreated= DateTime.UtcNow;
        this.Reviews= new HashSet<Review>();
        this.Sizes = new HashSet<ClothingSizes>();
    }

    [Required]
    [MaxLength(MaxMaterialNameLength)]
    public string Material { get; set; } = null!;

    [Required]
    public Category Category { get; set; }

    [Required]
    public Gender Gender { get; set; }

    public virtual ICollection<Review> Reviews { get; set; }

    public virtual ICollection<ClothingSizes> Sizes { get; set; }
}