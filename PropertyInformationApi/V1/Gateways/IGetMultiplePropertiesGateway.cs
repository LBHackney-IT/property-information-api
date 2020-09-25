using PropertyInformationApi.V1.Domain;
using System.Collections.Generic;

namespace PropertyInformationApi.V1.Gateways
{
    public interface IGetMultiplePropertiesGateway
    {
        List<HousingProperty> GetMultiplePropertiesByPropertyListOfReferences(IList<string> propertyReferences);
    }
}
