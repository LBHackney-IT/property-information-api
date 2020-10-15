using PropertyInformationApi.V1.Domain;
using PropertyInformationApi.V1.Infrastructure;

namespace PropertyInformationApi.V1.Mapper
{
    public interface IEntityMapper
    {
        HousingProperty ToDomain(UHProperty uhProperty);
    }
}
