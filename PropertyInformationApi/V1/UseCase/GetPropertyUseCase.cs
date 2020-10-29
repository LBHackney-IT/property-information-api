using AutoMapper;
using PropertyInformationApi.V1.Domain;
using PropertyInformationApi.V1.Gateways;

namespace PropertyInformationApi.V1.UseCase
{
    public class GetPropertyUseCase : IGetPropertyUseCase
    {
        private readonly IPropertyGateway _gateway;
        private readonly IMapper _mapper;
        public GetPropertyUseCase(IPropertyGateway gateway, IMapper mapper)
        {
            _gateway = gateway;
            _mapper = mapper;
        }

        public HousingProperty Execute(string propertyReference)
        {
            var response = _gateway.GetPropertyByPropertyReference(propertyReference);
            return _mapper.Map<HousingProperty>(response);
        }
    }
}
