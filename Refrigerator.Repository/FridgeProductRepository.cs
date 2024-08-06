using Microsoft.EntityFrameworkCore;
using Refrigerator.Contracts.Repository;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Repository;

public class FridgeProductRepository : RepositoryBase<FridgeProduct>, IFridgeProductRepository
{
    public FridgeProductRepository(RepositoryContext context) : base(context)
    {
    }

    public async Task<IEnumerable<FridgeProduct>> GetProductsAsync(Guid id, bool trackChanges)
    => await FindAll(trackChanges)
        .Where(fp => fp.FridgeId == id)
        .Include(fp => fp.Product)
        .ToListAsync();
}