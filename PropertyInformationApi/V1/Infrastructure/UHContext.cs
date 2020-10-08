using Microsoft.EntityFrameworkCore;

namespace PropertyInformationApi.V1.Infrastructure
{
    public class UhContext : DbContext
    {
        public UhContext(DbContextOptions options) : base(options) { }

        public DbSet<UHProperty> UhProperties { get; set; }
    }
}
