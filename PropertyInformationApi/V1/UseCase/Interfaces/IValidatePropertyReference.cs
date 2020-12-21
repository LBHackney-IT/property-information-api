using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyInformationApi.V1.UseCase
{
    public interface IValidatePropertyReference
    {
        bool Execute(string postcode);
    }
}
