using System;
using PropertyInformationApi.V1.Domain;
using PropertyInformationApi.V1.Gateways;
using PropertyInformationApi.V1.Mapper;

namespace PropertyInformationApi.V1.UseCase
{
    public class GetProperty : IGetProperty
    {
        private readonly IPropertyGateway _gateway;
        private readonly EntityMapper _mapper;
        public GetProperty(IPropertyGateway gateway, EntityMapper mapper)
        {
            _gateway = gateway;
            _mapper = mapper;
        }
        public HousingProperty Execute(string propertyReference)
        {
            var response = _gateway.GetPropertyByPropertyReference(propertyReference);
            return _mapper.ToDomain(response);
        }

        //public class GetPropertyByRefResponse
        //{
        //    public readonly bool Success;
        //    public readonly Property Property;

        //    public GetPropertyByRefResponse(Property property)
        //    {
        //        if (property != null)
        //        {
        //            Success = true;
        //        }
        //        Property = property;
        //    }

        //}
    }
}
