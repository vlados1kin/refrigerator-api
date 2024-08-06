using Refrigerator.Domain.Entities;
using Refrigerator.Shared.DTO;

namespace Refrigerator.Contracts.Service;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetProductsAsync(Guid id, bool trackChanges);
}