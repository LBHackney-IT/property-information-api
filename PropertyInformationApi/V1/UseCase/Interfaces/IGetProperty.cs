using PropertyInformationApi.V1.Domain;

namespace PropertyInformationApi.V1.UseCase
{
    public interface IGetProperty
    {
        HousingProperty Execute(string propertyReference);
    }
}

