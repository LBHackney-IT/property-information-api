using System.Collections;
using System.Collections.Generic;
using PropertyInformationApi.V1.Domain;

namespace PropertyInformationApi.V1.UseCase.GetPropertyChildren.Models
{
    public class GetPropertyChildrenResponse
    {
        public IList<HousingProperty> Children { get; set; }
    }
}
