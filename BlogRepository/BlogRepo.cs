using BlogRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Vcommerce.Data;
using Vcommerce.Data.Models.Blog;

namespace BlogRepository;

public class BlogRepo:IBlogRepo
{

    private readonly VcommerceDbContext dbContext;

    public BlogRepo(VcommerceDbContext context)
    {
        this.dbContext = context;
    }

    public async Task AddAsync(BlogPost blog)
    {
        await dbContext.BlogPosts.AddAsync(blog);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(BlogPost blog)
    {
        dbContext.BlogPosts.Update(blog);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(BlogPost blog)
    {

        dbContext.BlogPosts.Remove(blog);
        await dbContext.SaveChangesAsync();

    }

    public async Task<BlogPost> GetByIdAsync(Guid blogId)
    {
        var blogPost = await dbContext.BlogPosts.Include(b => b.Author).FirstAsync(b => b.Id == blogId);

        return blogPost;
    }

    public async Task<BlogPost[]> GetAllBlogs()
    {
        var blogPosts = await dbContext.BlogPosts.ToArrayAsync();

        return blogPosts;
    }
}