using System.ComponentModel.DataAnnotations;
using Vcommerce.Data.Models.Users;
using static VCommerce.Common.DataBaseValidations.ReviewsValidations;

namespace Vcommerce.Web.ViewModels.Reviews;


public class AddReviewViewModel
{

    [Required]
    [StringLength(MaxDescriptionLength, MinimumLength = MinDescriptionLength)]
    public string Description { get; set; } = null!;

    [Required]
    public Guid ClothingId { get; set; }

    [Required]
    [Range(minimum: MinRating, maximum: MaxRating)]
    public int Rating { get; set; }

    [Required]
    public Guid UserPosted { get; set; }
}