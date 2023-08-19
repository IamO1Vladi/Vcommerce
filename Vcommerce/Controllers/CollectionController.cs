using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Services.CollectionServices.Interfaces;
using Vcommerce.Web.ViewModels.Collections;

namespace Vcommerce.Web.Controllers
{
    public class CollectionController : Controller
    {

        private readonly ICollectionService collectionService;

        public CollectionController(ICollectionService service)
        {
            this.collectionService = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> CollectionsList()
        {

            var collections = await collectionService.GetAllCollectionsForList();

            return View(collections);
        }

        [HttpGet]
        [Authorize]
        public  IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(AddOrEditCollectionViewModel model)
        {

            await collectionService.AddCollection(model);

            return RedirectToAction("CollectionsList", "Collection");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(Guid collectionId)
        {

            var colleciton = await collectionService.GetCollectionViewModelByIdAsync(collectionId);

            return View(colleciton);

        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(Guid collectionId, AddOrEditCollectionViewModel model)
        {

            await collectionService.EditCollection(model, collectionId);

            return RedirectToAction("CollectionsList", "Collection");

        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> Delete(Guid collectionId)
        {

            await collectionService.DeleteCollectionAsync(collectionId);

            return Json(new { success = true, redirectToUrl = "Item deleted successfully." });
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddClothesToCollection(Guid clothingId, Guid collectionId)
        {

            await collectionService.AddClothingToCollection(clothingId, collectionId);

            return Json(new { success = true, redirectToUrl = "Item deleted successfully." });
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddClothesToCollection(Guid collectionId, Gender gender)
        {

            var clothes = await collectionService.GetClothesByGenderForCollectionAsync(collectionId, gender);

            ViewData["collectionId"] = collectionId;

            return View("ListClothesByGenderForCollectionAdding",clothes);
        }

    }
}
