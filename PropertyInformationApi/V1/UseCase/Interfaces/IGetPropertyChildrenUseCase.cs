using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropertyInformationApi.V1.Domain;
using PropertyInformationApi.V1.UseCase.GetPropertyChildren.Models;

namespace PropertyInformationApi.V1.UseCase
{
    public interface IGetPropertyChildrenUseCase : IUseCaseResult<GetPropertyChildrenRequest, GetPropertyChildrenResponse>
    {

    }
}
