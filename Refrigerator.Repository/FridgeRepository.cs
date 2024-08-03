using Microsoft.EntityFrameworkCore;
using Refrigerator.Contracts.Repository;
using Refrigerator.Domain.Entities;
using Refrigerator.Shared.DTO;

namespace Refrigerator.Repository;

public class FridgeRepository : RepositoryBase<Fridge>, IFridgeRepository
{
    public FridgeRepository(RepositoryContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Fridge>> GetFridgesAsync(bool trackChanges)
        => await FindAll(trackChanges)
            .Include(f => f.Model)
            .OrderBy(f => f.Name)
            .ToListAsync();
}