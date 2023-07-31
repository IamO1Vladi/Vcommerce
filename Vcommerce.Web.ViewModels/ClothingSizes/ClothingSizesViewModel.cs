using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Vcommerce.Data.Models.Enums;

using static VCommerce.Common.DataBaseValidations.ProductValidations;

namespace Vcommerce.Web.ViewModels.ClothingSizes;

public class ClothingSizesViewModel
{
    

    [Required]
    public ClothesSizes Size { get; set; }

    [Required]
    [Range(minimum: MinQuantity, maximum: MaxQuantity)]
    public int SizeQuantity { get; set; }

    [Required]
    public Guid ClothingId { get; set; }

}