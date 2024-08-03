using AutoMapper;
using Refrigerator.Contracts.Repository;
using Refrigerator.Contracts.Service;

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
}