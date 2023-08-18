using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vcommerce.Data.Models.Enums;

using static VCommerce.Common.DataBaseValidations.OrderValidations;
using static VCommerce.Common.DataBaseValidations.ProductValidations;

namespace Vcommerce.Data.Models.JoinTableModels;

public class OrderedClothing
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [Range(minimum:MinQuantity,maximum:MaxQuantity)]
    public int Quantity { get; set; }

    [Required]
    public OrderStatus Status { get; set; }

    [Required]
    public ClothesSizes Size { get; set; }

    [Required]
    [ForeignKey(nameof(Clothing))]
    public Guid ClothingId { get; set; }

    public Clothes Clothing { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(Order))]
    public Guid OrderId { get; set; }

    public Order.Order Order { get; set; } = null!;



}