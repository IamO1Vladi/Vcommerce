using Vcommerce.Data.Models.Blog;
using Vcommerce.Web.ViewModels.BlogPosts;

namespace Vcommerce.Services.BlogServices.Interfaces;

public interface IBlogService
{

    public Task<ListAllBlogPostsViewModel[]> GetAllBlogsPostsViewModelAsync();

    public Task AddAsync(AddBlogPostViewModel blogPost);

    public Task<BlogPostDetailsViewModel> GetPostDetailsByIdAsync(Guid postId);

    public Task<EditBlogPostViewModel> GetPostForEditView(Guid postId);

    public Task EditAsync(EditBlogPostViewModel blogPost);

}