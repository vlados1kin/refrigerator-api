namespace Refrigerator.Contracts.Repository;

public interface IRepositoryManager
{
    IFridgeRepository Fridge { get; }
    IProductRepository Product { get; }
    Task SaveAsync();
}