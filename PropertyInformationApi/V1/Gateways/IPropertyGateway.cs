using System.Collections;
using PropertyInformationApi.V1.Domain;

namespace PropertyInformationApi.V1.Gateways
{
    public interface IPropertyGateway
    {
        HousingProperty GetPropertyByPropertyReference(string propertyReference);
    }
}
