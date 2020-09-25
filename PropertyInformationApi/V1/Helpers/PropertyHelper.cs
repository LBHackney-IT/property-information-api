using AutoMapper;
using PropertyInformationApi.V1.Infrastructure;
using PropertyInformationApi.V1.Domain;

namespace PropertyInformationApi.V1.Helpers
{
    public static class PropertyHelper
    {
        public static MapperConfiguration ConfigureMapper()
        {
            return new MapperConfiguration(cfg => { cfg.CreateMap<UHProperty, HousingProperty>(); });
        }
    }
}
