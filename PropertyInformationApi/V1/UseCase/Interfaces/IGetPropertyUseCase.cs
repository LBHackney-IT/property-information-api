using PropertyInformationApi.V1.Domain;

namespace PropertyInformationApi.V1.UseCase
{
    public interface IGetPropertyUseCase
    {
        HousingProperty Execute(string propertyReference);
    }
}

