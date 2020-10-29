using System.Collections.Generic;
using PropertyInformationApi.V1.Boundary.Request;
using PropertyInformationApi.V1.Domain;

namespace PropertyInformationApi.V1.UseCase.Interfaces
{
    public interface IGetPropertiesUseCase
    {
        List<HousingProperty> Execute(GetPropertiesRequest request);
    }
}

