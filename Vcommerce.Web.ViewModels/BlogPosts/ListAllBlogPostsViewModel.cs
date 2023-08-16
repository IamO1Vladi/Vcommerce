using System.ComponentModel.DataAnnotations;

namespace Vcommerce.Web.ViewModels.BlogPosts;

using static VCommerce.Common.DataBaseValidations.BlogPostValidations;

public class ListAllBlogPostsViewModel
{

    
    public Guid Id { get; set; }

    [StringLength(MaxTitleLength, MinimumLength = MinTitleLength)]
    public string Title { get; set; } = null!;

    [StringLength(MaxShortContextLength,MinimumLength = MinShortContextLength)]
    public string ShortContext { get; set; } = null!;

    public DateTime DatePosted { get; set; }

    public int NumberOfComments { get; set; }

    [StringLength(MaxImageUrlLength)]
    public string ThumbnailUrl { get; set; } = null!;


}