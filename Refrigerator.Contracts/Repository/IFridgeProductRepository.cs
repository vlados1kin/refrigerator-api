using Refrigerator.Domain.Entities;

namespace Refrigerator.Contracts.Repository;

public interface IFridgeProductRepository
{
    Task<IEnumerable<FridgeProduct>> GetProductsAsync(Guid id, bool trackChanges);
}