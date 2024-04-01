using AppMapper.Models;
using AutoMapper;

namespace AppMapper.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Coche, Vehiculo>();
            CreateMap<Vehiculo, Coche>();

        }
    }
}
