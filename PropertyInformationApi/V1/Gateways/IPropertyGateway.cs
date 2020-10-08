using PropertyInformationApi.V1.Infrastructure;

namespace PropertyInformationApi.V1.Gateways
{
    public interface IPropertyGateway
    {
        UHProperty GetPropertyByPropertyReference(string propertyReference);
    }
}
