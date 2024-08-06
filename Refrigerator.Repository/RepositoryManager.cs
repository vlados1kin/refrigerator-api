using Refrigerator.Contracts.Repository;

namespace Refrigerator.Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly Lazy<IFridgeRepository> _fridgeRepository;
    private readonly Lazy<IFridgeProductRepository> _productRepository;
    private readonly RepositoryContext _repositoryContext;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _fridgeRepository = new Lazy<IFridgeRepository>(() => new FridgeRepository(repositoryContext));
        _productRepository = new Lazy<IFridgeProductRepository>(() => new FridgeProductRepository(repositoryContext));
        _repositoryContext = repositoryContext;
    }

    public IFridgeRepository Fridge => _fridgeRepository.Value;
    public IFridgeProductRepository FridgeProduct => _productRepository.Value;

    public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
}