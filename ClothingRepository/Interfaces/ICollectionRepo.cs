using Vcommerce.Data.Models.Collections;

namespace ClothingRepository.Interfaces;

public interface ICollectionRepo
{

    public Task<Collection[]> GetAllCollectionsAsync();

    public Task<Collection> GetCollectionByIdAsync(Guid collectionId);

    public Task AddAsync(Collection item);

    public Task UpdateAsync(Collection item);

    public Task DeleteAsync(Collection item);

    public Task SaveChangesAsync();

}