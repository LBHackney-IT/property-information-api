using System;
using System.Linq;
using PropertyInformationApi.V1.Infrastructure;
using PropertyInformationApi.V1.Domain;
using PropertyInformationApi.V1.Mapper;
using System.Collections.Generic;

namespace PropertyInformationApi.V1.Gateways
{
    public class PropertyGateway : IPropertyGateway/*, IGetPropertyChildrenGateway, IGetMultiplePropertiesGateway*/
    {
        private readonly UhContext _uhContext;

        public PropertyGateway(UhContext uhContext)
        {
            _uhContext = uhContext;
        }
        public UHProperty GetPropertyByPropertyReference(string propertyReference)
        {
            var response = _uhContext.UhProperties.Find(propertyReference);
            if (response == null) return null;
            return response;
        }

        /*public IList<HousingProperty> GetPropertyChildren(string propertyReference)
        {
            var children = _uhContext.UhPropertys.Where(p => p.MajorRef == propertyReference);
            var listChildren = children.Select(c => _factory.FromUHProperty(c)).ToList();
            return listChildren;
        }

        public List<HousingProperty> GetMultiplePropertiesByPropertyListOfReferences(IList<string> propertyReferences)
        {
            if (propertyReferences == null)
            {
                return null;
            }
            var properties = _uhContext.UhPropertys.Where(prop => propertyReferences.Contains(prop.PropRef));
            List<Property> listProperties = properties.Select(prop => _factory.FromUHProperty(prop)).ToList();
            return listProperties;
        }*/
    }
}
