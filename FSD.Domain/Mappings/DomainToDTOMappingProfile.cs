using AutoMapper;
using FSD.Domain.Dtos;
using FSD.Infrastructure.Context.Entities;

namespace FSD.Domain.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Order, OrderDto>().ReverseMap();
        }
    }
}

