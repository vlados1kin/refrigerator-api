using AutoMapper;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Refrigerator.Contracts.Repository;
using Refrigerator.Contracts.Service;
using Refrigerator.Repository;

namespace Repository.Service;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IFridgeService> _fridgeService;
    private readonly Lazy<IProductService> _productService;
    
    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _fridgeService = new Lazy<IFridgeService>(() => new FridgeService(repositoryManager, mapper));
        _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, mapper));
    }

    public IFridgeService FridgeService => _fridgeService.Value;
    public IProductService ProductService => _productService.Value;
}