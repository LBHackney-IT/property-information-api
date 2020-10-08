using PropertyInformationApi.V1.Domain;
using PropertyInformationApi.V1.Gateways.GetMultipleProperties;
using PropertyInformationApi.V1.UseCase.GetMultipleProperties.Boundaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyInformationApi.V1.UseCase.GetMultipleProperties.Impl
{
    public class GetMultiplePropertiesUseCase : IGetMultiplePropertiesUseCase
    {
        private IGetMultiplePropertiesGateway _getMultiplePropertiesGateway;

        public GetMultiplePropertiesUseCase(IGetMultiplePropertiesGateway getMultiplePropertiesGateway)
        {
            _getMultiplePropertiesGateway = getMultiplePropertiesGateway;
        }

        public GetMultiplePropertiesUseCaseResponse Execute(GetMultiplePropertiesUseCaseRequest request)
        {
            IList<string> propertyReferences = request.PropertyReferences;

            List<Property> properties = _getMultiplePropertiesGateway.GetMultiplePropertiesByPropertyListOfReferences(propertyReferences);

            return new GetMultiplePropertiesUseCaseResponse(properties);
        }
    }

}
