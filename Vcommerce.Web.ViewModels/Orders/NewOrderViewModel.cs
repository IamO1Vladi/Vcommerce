using System.ComponentModel.DataAnnotations;
using Vcommerce.Data.Models.Enums;

using static VCommerce.Common.DataBaseValidations.OrderValidations;

using static VCommerce.Common.DataBaseValidations.UserValidations;

namespace Vcommerce.Web.ViewModels.Orders;

public class NewOrderViewModel
{
    [Required]
    [StringLength(MaxFirstNameLength,MinimumLength = MinFirstNameLength)]
    public string FirstName { get; set; } = null!;

    [Required]
    [StringLength(MaxLastNameLentgh,MinimumLength = MinLastNameLength)]
    public string LastName { get; set; } = null!;

    [Required]
    [StringLength(MaxCountryLength, MinimumLength = MinConttyLength)]
    public string Country { get; set; } = null!;

    [Required]
    [StringLength(MaxCityLength, MinimumLength = MinCityLength)]
    public string City { get; set; } = null!;

    [Required]
    [StringLength(MaxStreetLength, MinimumLength = MinStretLength)]
    public string Street { get; set; } = null!;

    [Required]
    [StringLength(MaxPostalCodeLength, MinimumLength = MinPostalCodeLength)]
    public string PostalCode { get; set; } = null!;

    [Required]
    [Range(minimum: MinTotalClothingPrice, maximum: MaxTotalClothingPrice)]
    public decimal ClothesTotalPrice { get; set; }

    [Required]
    [Range(minimum: MinShhippingPrice, maximum: MaxShippingPrice)]
    public decimal ShippingPrice { get; set; }

    [Required]
    [Range(minimum: MinTotalPrice, maximum: MaxTotalPrice)]
    public decimal TotalPrice { get; set; }

    [Required] 
    [EmailAddress] 
    public string Email { get; set; } = null!;

    [Required] 
    [Phone]
    public string PhoneNumber { get; set; } = null!;

    [Required]
    public PaymentType PaymentType { get; set; }

    public Guid? UserId { get; set; }


}