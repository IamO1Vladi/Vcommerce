using Vcommerce.Data.Models.Blog;

namespace BlogRepository.Interfaces;

public interface IBlogRepo
{
    
    public Task AddAsync(BlogPost  blog);

    public Task UpdateAsync(BlogPost blog);

    public Task DeleteAsync(BlogPost blog);

    public Task<BlogPost> GetByIdAsync(Guid blogId);

    public Task<BlogPost[]> GetAllBlogs();

}