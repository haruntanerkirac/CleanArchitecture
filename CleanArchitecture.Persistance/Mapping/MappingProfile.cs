using AutoMapper;
using CleanArchitecture.Application.Features.CarFeatures.Command.CreateCar;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Persistence.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCarCommand, Car>().ReverseMap();
        }
    }
}
