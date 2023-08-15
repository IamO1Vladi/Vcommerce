using ClothingRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Vcommerce.Data;
using Vcommerce.Data.Models.Collections;

namespace ClothingRepository;

public class CollectionRepo:ICollectionRepo
{

    private readonly VcommerceDbContext dbContext;

    public CollectionRepo(VcommerceDbContext context)
    {
        this.dbContext = context;
    }


    public async Task<Collection[]> GetAllCollectionsAsync()
    {
        var collections = await dbContext.Collections.ToArrayAsync();

        return collections;
    }

    public async Task<Collection> GetCollectionByIdAsync(Guid collectionId)
    {
        var collection = await dbContext.Collections.FindAsync(collectionId);

        return collection;
    }

    public async Task AddAsync(Collection item)
    {
        await dbContext.Collections.AddAsync(item);

        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Collection item)
    {
        dbContext.Collections.Update(item);

        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Collection item)
    {
        dbContext.Collections.Remove(item);
        await dbContext.SaveChangesAsync();
    }

    public async Task SaveChangesAsync()
    {
        await dbContext.SaveChangesAsync();
    }
}