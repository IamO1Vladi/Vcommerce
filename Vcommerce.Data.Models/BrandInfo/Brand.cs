using System.ComponentModel.DataAnnotations;

using static VCommerce.Common.DataBaseValidations.BrandValidations;

namespace Vcommerce.Data.Models.BrandInfo;

public class Brand
{

    public Brand()
    {
        this.Id=Guid.NewGuid();
        this.Clothes = new HashSet<Clothes>();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(MaxNameLength)]
    public string Name { get; set; }

    
    [MaxLength(MaxDescriptionLength)]
    public string? Description { get; set; }

    
    [MaxLength(MaxUrlLength)]
    public string? LogoUrl { get; set; } 

    public virtual ICollection<Clothes> Clothes { get; set; } = null!;

}