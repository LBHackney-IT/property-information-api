using Microsoft.EntityFrameworkCore;
using PropertyInformationApi.V1.Infrastructure;

namespace PropertyInformationApi.V1.Data
{
    public interface IUHContext
    {
        DbSet<UHProperty> UhProperties { get; set; }
    }
}
