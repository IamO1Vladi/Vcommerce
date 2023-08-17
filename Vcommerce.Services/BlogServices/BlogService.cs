using BlogRepository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Vcommerce.Data.Models.Blog;
using Vcommerce.Data.Models.Users;
using Vcommerce.Services.ApiServices.FireBaseApiService.Interfaces;
using Vcommerce.Services.BlogServices.Interfaces;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.BlogPosts;

using static VCommerce.Common.DataBaseValidations.BlogPostValidations;

namespace Vcommerce.Services.BlogServices;

public class BlogService:IBlogService
{

    private readonly IBlogRepo blogRepo;
    private readonly IImagesService imagesService;


    public BlogService(IBlogRepo repo, IImagesService service)
    {
        this.blogRepo = repo;
        this.imagesService = service;
       
    }

    public async Task<ListAllBlogPostsViewModel[]> GetAllBlogsPostsViewModelAsync()
    {
        var blogPosts = await blogRepo.GetAllBlogs();

        ICollection<ListAllBlogPostsViewModel> blogPostsView = new HashSet<ListAllBlogPostsViewModel>();

        ListAllBlogPostsViewModel post;

        foreach (var blogPost in blogPosts)
        {

            post = new ListAllBlogPostsViewModel
            {
                Id = blogPost.Id,
                Title = blogPost.Title,
                ShortContext = blogPost.Context.Length > MaxShortContextLength
                    ? blogPost.Context.Substring(0, MaxShortContextLength)
                    : blogPost.Context,
                DatePosted = blogPost.DatePosted,
                NumberOfComments = 0,
                ThumbnailUrl = blogPost.PostMainPictureUrl,
            };

            blogPostsView.Add(post);

        }

        return blogPostsView.ToArray();
    }

    public async Task AddAsync(AddBlogPostViewModel blogPost)
    {

        string mainPictureUrl = await imagesService.AddBlogImageAsync(blogPost.ThumbMail);
        string leftPictureUrl = await imagesService.AddBlogImageAsync(blogPost.LeftSideImage);
        string rightPictureUrl = await imagesService.AddBlogImageAsync(blogPost.RightSideImage);

        BlogPost newPost = new BlogPost
        {
            Title = blogPost.Title,
            DatePosted = DateTime.UtcNow,
            PostMainPictureUrl = mainPictureUrl,
            PostMidSectionLeftImageUrl = leftPictureUrl,
            PostMidSectionRightImageUrl = rightPictureUrl,
            Context = blogPost.Context,
            AuthorId = blogPost.AuthorId,

        };

        await blogRepo.AddAsync(newPost);

    }

    public async Task<BlogPostDetailsViewModel> GetPostDetailsByIdAsync(Guid postId)
    {
        BlogPost post = await blogRepo.GetByIdAsync(postId);



        BlogPostDetailsViewModel details = new BlogPostDetailsViewModel
        {
            Id = post.Id,
            Title = post.Title,
            Context = post.Context,
            MainImageUrl = post.PostMainPictureUrl,
            LeftSideImageUrl = post.PostMidSectionLeftImageUrl,
            RightSideImageUrl = post.PostMidSectionRightImageUrl,
            DatePosted = post.DatePosted,
            NumberOfComments = 0,
            Author = post.Author,
        };

        return details;
    }

    public async Task<EditBlogPostViewModel> GetPostForEditView(Guid postId)
    {
        BlogPost currentPost = await blogRepo.GetByIdAsync(postId);

        EditBlogPostViewModel post = new EditBlogPostViewModel()
        {
            Context = currentPost.Context,
            Title = currentPost.Title,
            Id=postId,
        };

        return post;

    }

    public async Task EditAsync(EditBlogPostViewModel blogPost)
    {
        BlogPost currentPost = await blogRepo.GetByIdAsync(blogPost.Id);

       currentPost.Context=blogPost.Context;
       currentPost.Title=blogPost.Title;

       await blogRepo.UpdateAsync(currentPost);


    }
}