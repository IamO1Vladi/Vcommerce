using System.ComponentModel.DataAnnotations;
using Vcommerce.Data.Models.Enums;

namespace Vcommerce.Data.Models;

public class Clothes:Product
{
    public Clothes()
    {
        this.Id = new Guid();
        this.Images = new HashSet<ProductImages>();
    }

    [Required]
    public string Material { get; set; } = null!;

    [Required]
    public ClothesSizes Size { get; set; }

    [Required]
    public Category Category { get; set; }

    [Required]
    public Gender Gender { get; set; }

    public override ICollection<ProductImages> Images { get; set; }
}