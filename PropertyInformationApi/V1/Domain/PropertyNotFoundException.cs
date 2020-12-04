using System;

namespace PropertyInformationApi.V1.Domain
{
    public class PropertyNotFoundException : Exception
    {
        public PropertyNotFoundException() { }
        public PropertyNotFoundException(string message)
           : base(message)
        {
        }
    }
}
