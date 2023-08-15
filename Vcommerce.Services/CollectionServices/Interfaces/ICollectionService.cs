using Vcommerce.Web.ViewModels.Collections;

namespace Vcommerce.Services.CollectionServices.Interfaces;

public interface ICollectionService
{

    public Task<ListAllCollectionsViewModel[]> GetAllCollectionsForList();

    public Task AddCollection(AddOrEditCollectionViewModel model);

    public Task EditCollection(AddOrEditCollectionViewModel model,Guid collectionId);

    public Task<AddOrEditCollectionViewModel> GetCollectionViewModelByIdAsync(Guid collectionId);

    public Task DeleteCollectionAsync(Guid collectionId);

}