using System.ComponentModel.DataAnnotations;
using Vcommerce.Data.Models.Enums;

using static VCommerce.Common.DataBaseValidations.CollectionValidations;

namespace Vcommerce.Web.ViewModels.Collections;

public class AddOrEditCollectionViewModel
{

    [Required]
    [StringLength(MaxNameLength, MinimumLength = MinNameLength)]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(MaxDescriptionLength,MinimumLength = MinDescriptionLength)]
    public string Description { get; set; } = null!;

    [Required]
    public Gender Gender { get; set; }

}