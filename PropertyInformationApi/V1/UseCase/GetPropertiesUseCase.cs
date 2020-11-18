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
        private readonly IMapper _mapper;
        private readonly IValidatePostcode _validatePostcode;

        public GetPropertiesUseCase(IPropertyGateway gateway, IMapper mapper, IValidatePostcode validatePostcode)
        {
            _gateway = gateway;
            _mapper = mapper;
            _validatePostcode = validatePostcode;
        }

        public List<HousingProperty> Execute(GetPropertiesRequest request)
        {
            if (!_validatePostcode.Execute(request.Postcode))
                throw new InvalidQueryParameterException("The Postcode parameter does not have a valid format");
            var response = _gateway.GetPropertiesByPostcodeOrAddress(request);
            return _mapper.Map<List<HousingProperty>>(response);
        }
    }
}
