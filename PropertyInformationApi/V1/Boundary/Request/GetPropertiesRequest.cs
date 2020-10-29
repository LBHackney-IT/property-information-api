using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PropertyInformationApi.V1.Boundary.Request
{
    public class GetPropertiesRequest
    {
        public string Postcode { get; set; }
        public string Address { get; set; }

        public Dictionary<string, string> GetQueryDict()
        {
            var dict = new Dictionary<string, string>();
            foreach (var prop in typeof(GetPropertiesRequest).GetProperties())
                if (prop.GetValue(this, null) != null)
                    dict.Add(prop.Name, prop.GetValue(this, null)?.ToString());

            return dict;
        }
    }
}
