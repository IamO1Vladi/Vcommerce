using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Web.ViewModels.Clothes;
using Vcommerce.Web.ViewModels.Collections;

namespace Vcommerce.Services.CollectionServices.Interfaces;

public interface ICollectionService
{

    public Task<ListAllCollectionsViewModel[]> GetAllCollectionsForList();

    public Task AddCollection(AddOrEditCollectionViewModel model);

    public Task EditCollection(AddOrEditCollectionViewModel model,Guid collectionId);

    public Task<AddOrEditCollectionViewModel> GetCollectionViewModelByIdAsync(Guid collectionId);

    public Task DeleteCollectionAsync(Guid collectionId);

    public Task AddClothingToCollection(Guid clothingId, Guid collectionId);

    public Task<ListClothesByGenderForCollection[]>
        GetClothesByGenderForCollectionAsync(Guid collectionId, Gender gender);

}