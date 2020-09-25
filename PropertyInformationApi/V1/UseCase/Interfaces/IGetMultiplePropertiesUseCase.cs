using PropertyInformationApi.V1.UseCase.GetMultipleProperties.Boundaries;

namespace PropertyInformationApi.V1.UseCase
{ 
    public interface IGetMultiplePropertiesUseCase
    {
        GetMultiplePropertiesUseCaseResponse Execute(GetMultiplePropertiesUseCaseRequest request);
    }
}
