using System.Collections.Generic;
using AutoMapper;
using PropertyInformationApi.V1.Boundary.Request;
using PropertyInformationApi.V1.Domain;
using PropertyInformationApi.V1.Gateways;
using PropertyInformationApi.V1.UseCase.Interfaces;

namespace PropertyInformationApi.V1.UseCase
{
    public class GetPropertiesUseCase : IGetPropertiesUseCase
    {
        private readonly IPropertyGateway _gateway;
        private readonly IMapper          _mapper;

        public GetPropertiesUseCase(IPropertyGateway gateway, IMapper mapper)
        {
            _gateway = gateway;
            _mapper  = mapper;
        }

        public List<HousingProperty> Execute(GetPropertiesRequest request)
        {
            var response = _gateway.GetPropertiesByPostcodeOrAddress(request);
            return _mapper.Map<List<HousingProperty>>(response);
        }
    }
}
