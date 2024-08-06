using AutoMapper;
using Refrigerator.Contracts.Repository;
using Refrigerator.Contracts.Service;
using Refrigerator.Domain.Entities;
using Refrigerator.Shared.DTO;

namespace Repository.Service;

public class ProductService : IProductService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    
    public ProductService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProductDto>> GetProductsAsync(Guid id, bool trackChanges)
    {
        var products = await _repositoryManager.FridgeProduct.GetProductsAsync(id, trackChanges);
        var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);
        return productsDto;
    }
}