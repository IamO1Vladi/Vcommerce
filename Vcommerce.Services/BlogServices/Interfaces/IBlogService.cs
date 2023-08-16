using Vcommerce.Data.Models.Blog;

namespace Vcommerce.Services.BlogServices.Interfaces;

public interface IBlogService
{

    public Task<BlogPost> GetAllBlogsPostsViewModelAsync();

    public Task AddAsync();

}