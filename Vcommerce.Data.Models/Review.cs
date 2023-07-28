using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vcommerce.Data.Models.Users;
using static VCommerce.Common.DataBaseValidations.ReviewsValidations;

namespace Vcommerce.Data.Models;

public class Review
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public ApplicationUser UserPosted { get; set; } = null!;

    [Required]
    public DateOnly DatePosted { get; set; }

    [Required]
    [MaxLength(MaxAvatarUrlLength)]
    public string AvatarUrl { get; set; } = null!;

    [Required]
    [Range(minimum:MinRating,maximum:MaxRating)]
    public int Rating { get; set; }

    [MaxLength(MaxDescriptionLength)]
    public string? Description { get; set; }

    [Required]
    [ForeignKey(nameof(RelatedClothing))]
    public Guid RelatedClothingIdGuid{ get; set; }

    public Clothes RelatedClothing { get; set; } = null!;



}