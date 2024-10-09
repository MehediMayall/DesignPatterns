using AutoMapper;

namespace CqrsWithEvents;

public class MappingProfile : Profile {
    public MappingProfile()
    {
        CreateMap<Order, OrderForCreateDto>().ReverseMap();
        CreateMap<Order, OrderForReturnDto>().ReverseMap();
        CreateMap<Order, OrderForUpdateDto>().ReverseMap();

    }
}