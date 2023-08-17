﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
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

        public async Task<IActionResult> Add(AddBlogPostViewModel model)
        {

            await blogService.AddAsync(model);

            return RedirectToAction("ListAllBlogPosts", "Blog");
        }


        [HttpGet]

        public async Task<IActionResult> Details(Guid postId)
        {

            var details = await blogService.GetPostDetailsByIdAsync(postId);


            return View(details);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid postId)
        {

            EditBlogPostViewModel model = await blogService.GetPostForEditView(postId);

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(EditBlogPostViewModel model)
        {

            await blogService.EditAsync(model);

            return RedirectToAction("Details", "Blog", new { postId = model.Id });

        }
    }
}
