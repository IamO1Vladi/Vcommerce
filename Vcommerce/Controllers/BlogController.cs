using Microsoft.AspNetCore.Mvc;
using Vcommerce.Services.BlogServices.Interfaces;
using Vcommerce.Web.ViewModels.BlogPosts;

namespace Vcommerce.Web.Controllers
{
    public class BlogController : Controller
    {

        private readonly IBlogService blogService;

        public BlogController(IBlogService serice)
        {
            this.blogService = serice;
        }

        public async Task<IActionResult> ListAllBlogPosts()
        {

            var blogPosts = await blogService.GetAllBlogsPostsViewModelAsync();

            return View(blogPosts);
        }

        [HttpGet]

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddOrEditBlogPostViewModel model)
        {

            await blogService.AddAsync(model);

            return RedirectToAction("ListAllBlogPosts", "Blog");
        }
    }
}
