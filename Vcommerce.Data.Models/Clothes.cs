using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vcommerce.Data.Models.BrandInfo;
using Vcommerce.Data.Models.Collections;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Data.Models.JoinTableModels;
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
        this.Orders = new HashSet<OrderedClothing>();
    }

    [Required]
    [ForeignKey(nameof(Brand))]
    public Guid BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;


    [ForeignKey(nameof(Collection))]
    public Guid? CollectionId { get; set; }

    public Collection? Collection { get; set; }

    [Required]
    [MaxLength(MaxMaterialNameLength)]
    public string Material { get; set; } = null!;

    [Required]
    public Category Category { get; set; }

    [Required]
    public Gender Gender { get; set; }

    public virtual ICollection<Review> Reviews { get; set; }

    public virtual ICollection<ClothingSizes> Sizes { get; set; }

    public virtual ICollection<OrderedClothing> Orders { get; set; }



}