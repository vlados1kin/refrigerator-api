using Refrigerator.Contracts.Repository;

namespace Refrigerator.Contracts.Service;

public interface IServiceManager
{
    IFridgeService FridgeService { get; }
    IProductService ProductService { get; }
}