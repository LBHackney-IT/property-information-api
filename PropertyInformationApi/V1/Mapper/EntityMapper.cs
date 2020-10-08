using AutoMapper;
using PropertyInformationApi.V1.Domain;
using PropertyInformationApi.V1.Infrastructure;

namespace PropertyInformationApi.V1.Mapper
{
    public class EntityMapper
    {
        private readonly IMapper _mapper;

        public EntityMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public HousingProperty ToDomain(UHProperty uhproperty)
        {
            return _mapper.Map<HousingProperty>(uhproperty);
        }
    }
}
