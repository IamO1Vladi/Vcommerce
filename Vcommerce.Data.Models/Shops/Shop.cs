using System.ComponentModel.DataAnnotations;

using static VCommerce.Common.DataBaseValidations.OrderValidations;
using static VCommerce.Common.DataBaseValidations.ShopValidation;

namespace Vcommerce.Data.Models.Shops;

public class Shop
{
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
    [Range(typeof(DateTime), OldestDate, NewestDate, ErrorMessage = "Date Opened must be between 1/1/1800 and 12/31/2022.")]
    public DateTime DateOpened { get; set; }

    [Required]
    [RegularExpression(TimeValidation, ErrorMessage = "Invalid Start Time format. Use HH:mm.")]
    public string StartTime { get; set; }
    [Required]
    [RegularExpression(TimeValidation, ErrorMessage = "Invalid End Time format. Use HH:mm.")]
    public string EndTime { get; set; }


}