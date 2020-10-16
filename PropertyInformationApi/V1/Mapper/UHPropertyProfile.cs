using AutoMapper;
using PropertyInformationApi.V1.Domain;
using PropertyInformationApi.V1.Infrastructure;

namespace PropertyInformationApi.V1.Mapper
{
    public class UHPropertyProfile : Profile
    {
        public UHPropertyProfile() => CreateMap<UHProperty, HousingProperty>();
    }
}
