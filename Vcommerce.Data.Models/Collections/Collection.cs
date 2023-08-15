using System.ComponentModel.DataAnnotations;
using Vcommerce.Data.Models.Enums;

using static VCommerce.Common.DataBaseValidations.CollectionValidations;

namespace Vcommerce.Data.Models.Collections;

public class Collection
{

    public Collection()
    {
        this.Id=Guid.NewGuid();
        this.Clothes = new HashSet<Clothes>();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(MaxNameLength)]
    public string Name { get; set; }

    [Required]
    [MaxLength(MaxDescriptionLength)]
    public string Description { get; set; }

    [Required]
    public Gender Gender { get; set; }

    public virtual ICollection<Clothes> Clothes { get; set; }


}