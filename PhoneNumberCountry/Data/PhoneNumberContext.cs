using Microsoft.EntityFrameworkCore;
using PhoneNumberCountry.Models;

namespace PhoneNumberCountry.Data
{
    public class PhoneNumberContext : DbContext
    {
        public PhoneNumberContext(DbContextOptions<PhoneNumberContext> options)
            : base(options)
        {
        }

        // Define DbSet properties for your entities (e.g., Country and CountryDetail)
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryDetail> CountryDetails { get; set; }

        // Additional configuration, if needed
    }

}
