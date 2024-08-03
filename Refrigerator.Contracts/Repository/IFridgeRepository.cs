using Refrigerator.Domain.Entities;

namespace Refrigerator.Contracts.Repository;

public interface IFridgeRepository
{
    Task<IEnumerable<Fridge>> GetFridgesAsync(bool trackChanges);
}