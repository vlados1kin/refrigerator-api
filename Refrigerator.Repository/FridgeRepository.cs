using Refrigerator.Contracts.Repository;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Repository;

public class FridgeRepository : RepositoryBase<Fridge>, IFridgeRepository
{
    public FridgeRepository(RepositoryContext context) : base(context)
    {
    }
}