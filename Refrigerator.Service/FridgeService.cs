using AutoMapper;
using Refrigerator.Contracts.Repository;
using Refrigerator.Contracts.Service;
using Refrigerator.Shared.DTO;

namespace Repository.Service;

public class FridgeService : IFridgeService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    
    public FridgeService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public async Task<IEnumerable<FridgeDto>> GetFridgesAsync(bool trackChanges)
    {
        var fridges = await _repositoryManager.Fridge.GetFridgesAsync(trackChanges);
        var fridgesDto = _mapper.Map<IEnumerable<FridgeDto>>(fridges);
        return fridgesDto;
    }
}