using Vcommerce.Data.Models.Blog;
using Vcommerce.Web.ViewModels.BlogPosts;

namespace Vcommerce.Services.BlogServices.Interfaces;

public interface IBlogService
{

    public Task<ListAllBlogPostsViewModel[]> GetAllBlogsPostsViewModelAsync();

    public Task AddAsync(AddOrEditBlogPostViewModel blogPost);

}