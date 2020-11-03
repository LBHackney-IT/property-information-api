using System;
using System.Linq;
using PropertyInformationApi.V1.Infrastructure;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PropertyInformationApi.V1.Boundary.Request;

namespace PropertyInformationApi.V1.Gateways
{
    public class PropertyGateway : IPropertyGateway
    {
        private readonly UhContext _uhContext;

        public PropertyGateway(UhContext uhContext)
        {
            _uhContext = uhContext;
        }

        public UHProperty GetPropertyByPropertyReference(string propertyReference)
        {
            var response = _uhContext.UhProperties.Find(propertyReference);
            return response;
        }

        public IEnumerable<UHProperty> GetPropertiesByPostcodeOrAddress(GetPropertiesRequest request) =>
            _uhContext.UhProperties.Where(property =>
                property.Address1.Contains(request.Address) ||
                property.PostCode.StartsWith(request.Postcode));
    }
}
