using System.Collections.Generic;
using PropertyInformationApi.V1.Domain;

namespace PropertyInformationApi.V1.Gateways
{
    public interface IGetPropertyChildrenGateway
    {
        IList<HousingProperty> GetPropertyChildren(string propertyReference);
    }
}
