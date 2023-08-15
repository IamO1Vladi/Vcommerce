using ClothingRepository.Interfaces;
using Vcommerce.Data.Models.Collections;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Services.CollectionServices.Interfaces;
using Vcommerce.Web.ViewModels.Collections;

namespace Vcommerce.Services.CollectionServices;

public class CollectionService:ICollectionService
{

    private readonly ICollectionRepo collectionRepo;

    public CollectionService(ICollectionRepo repo)
    {
        this.collectionRepo = repo;
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
}