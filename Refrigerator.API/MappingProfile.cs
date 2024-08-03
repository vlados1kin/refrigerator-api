using AutoMapper;
using Refrigerator.Domain.Entities;
using Refrigerator.Shared.DTO;

namespace Refrigerator.API;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Fridge, FridgeDto>()
            .ForMember(dest => dest.ModelDto, opt => opt.MapFrom(src => src.Model));
        CreateMap<Model, ModelDto>();
    }
}