using System.Collections.Generic;
using PropertyInformationApi.V1.Boundary.Request;
using PropertyInformationApi.V1.Infrastructure;

namespace PropertyInformationApi.V1.Gateways
{
    public interface IPropertyGateway
    {
        UHProperty GetPropertyByPropertyReference(string propertyReference);
        IEnumerable<UHProperty> GetPropertiesByPostcodeOrAddress(GetPropertiesRequest request);
    }
}
