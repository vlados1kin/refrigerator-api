using AutoMapper;
using Refrigerator.Domain.Entities;
using Refrigerator.Shared.DTO;

namespace Refrigerator.API;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Fridge, FridgeDto>().ForMember(dest => dest.ModelDto, opt => opt.MapFrom(src => src.Model));
        CreateMap<Model, ModelDto>();
        CreateMap<FridgeProduct, ProductDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Product.Name))
            .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity));
    }
}