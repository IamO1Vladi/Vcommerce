using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Vcommerce.Data.Models.Users;

using static VCommerce.Common.DataBaseValidations.BlogPostValidations;

namespace Vcommerce.Web.ViewModels.BlogPosts;

public class AddOrEditBlogPostViewModel
{

    [Required]
    [StringLength(MaxTitleLength, MinimumLength = MinTitleLength)]
    public string Title { get; set; } = null!;

    [Required] public IFormFile ThumbMail { get; set; } = null!;

    [Required] public IFormFile LeftSideImage { get; set; } = null!;

    [Required] public IFormFile RightSideImage { get; set; } = null!;

    [Required]
    [StringLength(MaxContextLength,MinimumLength = MinContextLength)]
    public string Context { get; set; } = null!;

    [Required]
    public Guid AuthorId { get; set; } 

}