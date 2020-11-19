using System.Text.RegularExpressions;

namespace PropertyInformationApi.V1.UseCase
{
    public class ValidatePostcode : IValidatePostcode
    {
        public bool Execute(string postcode)
        {
            const string pattern =
                "^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|" +
                "(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z])))) [0-9][A-Za-z]{2})$";

            return (postcode == null) || Regex.IsMatch(postcode, pattern);
        }
    }
}
