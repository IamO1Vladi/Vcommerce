using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Data.Models.JoinTableModels;
using Vcommerce.Data.Models.Users;

using static VCommerce.Common.DataBaseValidations.OrderValidations;

namespace Vcommerce.Data.Models.Order;

public class Order
{

    public Order()
    {
        this.Id= Guid.NewGuid();
        this.OrderedClothes = new HashSet<OrderedClothing>();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(MaxCountryLength)]
    public string Country { get; set; } = null!;

    [Required] 
    [MaxLength(MaxCityLength)] 
    public string City { get; set; } = null!;

    [Required]
    [MaxLength(MaxStreetLength)] 
    public string Street { get; set; } = null!;

    [Required]
    [MaxLength(MaxPostalCodeLength)] 
    public string PostalCode { get; set; } = null!;

    [Required]
    [Range(minimum:MinTotalClothingPrice,maximum:MaxTotalClothingPrice)]
    public decimal ClothesTotalPrice { get; set; }

    [Required]
    [Range(minimum: MinShhippingPrice,maximum:MaxShippingPrice)]
    public decimal ShippingPrice { get; set; }

    [Required]
    [Range(minimum:MinTotalPrice,maximum:MaxTotalPrice)]
    public decimal TotalPrice { get; set; }

    [Required][EmailAddress] 
    public string Email { get; set; } = null!;

    [Required][Phone] 
    public string PhoneNumber { get; set; } = null!;

    [Required]
    public PaymentType PaymentType { get; set; }

    public virtual ICollection<OrderedClothing> OrderedClothes { get; set; }

    
    [ForeignKey(nameof(ApplicationUser))]
    public Guid? UserId { get; set; }

    public virtual ApplicationUser? ApplicationUser { get; set; }

}