namespace Refrigerator.Contracts.Repository;

public interface IRepositoryManager
{
    IFridgeRepository Fridge { get; }
    IFridgeProductRepository FridgeProduct { get; }
    Task SaveAsync();
}