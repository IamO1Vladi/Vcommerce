using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vcommerce.Data.Models;

public class ProductImages
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string ImageUrl { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(RelatedProduct))]
    public Guid ProductGuid { get; set; }

    public virtual Product RelatedProduct { get; set; } = null!;

}