using ClothingRepository.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Collections;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Services.CollectionServices.Interfaces;
using Vcommerce.Web.ViewModels.Clothes;
using Vcommerce.Web.ViewModels.Collections;

namespace Vcommerce.Services.CollectionServices;

public class CollectionService:ICollectionService
{

    private readonly ICollectionRepo collectionRepo;
    private readonly IClothingRepo clothingRepo;

    public CollectionService(ICollectionRepo repo, IClothingRepo clothingRepo)
    {
        this.collectionRepo = repo;
        this.clothingRepo = clothingRepo;
    }

    public async Task<ListAllCollectionsViewModel[]> GetAllCollectionsForList()
    {

        ICollection<ListAllCollectionsViewModel> collectionList = new HashSet<ListAllCollectionsViewModel>();

        ListAllCollectionsViewModel collection;

        var collectionsFromDb = await collectionRepo.GetAllCollectionsAsync();

        foreach (var col in collectionsFromDb)
        {
            collection = new ListAllCollectionsViewModel
            {
                CollectionId = col.Id,
                Name = col.Name,
                Description = col.Description,
                Gender = col.Gender
            };
            collectionList.Add(collection);
        }


        return collectionList.ToArray();

    }

    public async Task AddCollection(AddOrEditCollectionViewModel model)
    {

        Collection collection = new Collection
        {
            Name = model.Name,
            Description = model.Description,
            Gender = model.Gender
        };

        await collectionRepo.AddAsync(collection);

    }

    public async Task EditCollection(AddOrEditCollectionViewModel model, Guid collectionId)
    {
        var collectionToEdit = await collectionRepo.GetCollectionByIdAsync(collectionId);

        collectionToEdit.Name = model.Name;
        collectionToEdit.Description = model.Description;
        collectionToEdit.Gender=model.Gender;

        await collectionRepo.UpdateAsync(collectionToEdit);
    }

    public async Task<AddOrEditCollectionViewModel> GetCollectionViewModelByIdAsync(Guid collectionId)
    {
        var collection = await collectionRepo.GetCollectionByIdAsync(collectionId);

        AddOrEditCollectionViewModel collectionToEdit = new AddOrEditCollectionViewModel
        {
            Name = collection.Name,
            Description = collection.Description,
            Gender = collection.Gender
        };

        return collectionToEdit;

    }

    public async Task DeleteCollectionAsync(Guid collectionId)
    {
        var collectionToDelete = await collectionRepo.GetCollectionByIdAsync(collectionId);

        await collectionRepo.DeleteAsync(collectionToDelete);
    }

    public async Task AddClothingToCollection(Guid clothingId, Guid collectionId)
    {
        Clothes clothing = await clothingRepo.GetClothingById(clothingId);

        clothing.CollectionId=collectionId;

        await clothingRepo.SaveChangesAsync();
    }

    public async Task<ListClothesByGenderForCollection[]> GetClothesByGenderForCollectionAsync(Guid collectionId, Gender gender)
    {
        var clothes = await clothingRepo.GetClothesByGender(gender);

        clothes = clothes.Where(c => c.CollectionId == null).ToArray();
        ICollection<ListClothesByGenderForCollection> clothesViewModel = new HashSet<ListClothesByGenderForCollection>();

        ListClothesByGenderForCollection model;

        foreach (var clothing in clothes)
        {
            model = new ListClothesByGenderForCollection
            {
                Id = clothing.Id,
                Name = clothing.Name,
                Price = clothing.Price,
                ImageUrl = clothing.Images.Count > 0
                    ? clothing.Images.First().ImageUrl
                    : "/assets/images/product_img2.jpg",
                Gender = clothing.Gender
            };

            clothesViewModel.Add(model);

        }

        return clothesViewModel.ToArray();
    }
}