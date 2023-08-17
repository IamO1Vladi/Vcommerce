using Vcommerce.Data.Models.Users;

namespace Vcommerce.Web.ViewModels.BlogPosts;

public class BlogPostDetailsViewModel
{
    
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Context { get; set; } = null!;

    public string MainImageUrl { get; set; } = null!;

    public string LeftSideImageUrl { get; set; } = null!;

    public string RightSideImageUrl { get; set; } = null!;

    public DateTime DatePosted { get; set; }

    public int NumberOfComments { get; set; }

    public ApplicationUser Author { get; set; } = null!;



}