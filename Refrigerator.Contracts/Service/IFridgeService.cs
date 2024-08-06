using Refrigerator.Shared.DTO;

namespace Refrigerator.Contracts.Service;

public interface IFridgeService
{
    Task<IEnumerable<FridgeDto>> GetFridgesAsync(bool trackChanges);
}