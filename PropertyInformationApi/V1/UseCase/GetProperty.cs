using System;
using PropertyInformationApi.V1.Domain;
using PropertyInformationApi.V1.Gateways;

namespace PropertyInformationApi.V1.UseCase
{
    public class GetProperty : IGetProperty
    {
        private readonly IPropertyGateway _gateway;
        public GetProperty(IPropertyGateway gateway)
        {
            _gateway = gateway;
        }
        public HousingProperty Execute(string propertyReference)
        {
            var response = _gateway.GetPropertyByPropertyReference(propertyReference);

            return response;
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
