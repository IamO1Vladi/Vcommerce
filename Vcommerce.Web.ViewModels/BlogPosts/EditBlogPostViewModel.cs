using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

using static VCommerce.Common.DataBaseValidations.BlogPostValidations;

namespace Vcommerce.Web.ViewModels.BlogPosts;

public class EditBlogPostViewModel
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    [StringLength(MaxTitleLength, MinimumLength = MinTitleLength)]
    public string Title { get; set; } = null!;

    [Required]
    [StringLength(MaxContextLength, MinimumLength = MinContextLength)]
    public string Context { get; set; } = null!;

 
}