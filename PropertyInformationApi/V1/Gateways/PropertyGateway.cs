using System.Linq;
using PropertyInformationApi.V1.Infrastructure;
using System.Collections.Generic;
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
            from property in _uhContext.UhProperties
            where property.ShortAddress == request.Address || property.PostCode == request.Postcode
            select property;
    }
}
