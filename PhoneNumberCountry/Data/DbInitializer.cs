using PhoneNumberCountry.Models;

namespace PhoneNumberCountry.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PhoneNumberContext context)
        {
            context.Database.EnsureCreated();

            if (context.Countries.Any())
            {
                return; // Database has been seeded
            }

            // Add sample data for the Country entity
            var countries = new List<Country>
            {
                new Country { CountryCode = "234", Name = "Nigeria", CountryIso = "NG" },
                new Country { CountryCode = "233", Name = "Ghana", CountryIso = "GH" },
                new Country { CountryCode = "229", Name = "Benin Republic", CountryIso = "BN" },
                new Country { CountryCode = "225", Name = "Côte d'Ivoire", CountryIso = "CIV" },
            };
                context.Countries.AddRange(countries);

            // Add sample data for the CountryDetail entity
            var countryDetails = new List<CountryDetail>
            {
                new CountryDetail { CountryId = 1, Operator = "MTN Nigeria", OperatorCode = "MTN NG" },
                new CountryDetail { CountryId = 1, Operator = "Airtel Nigeria", OperatorCode = "ANG" },
                new CountryDetail { CountryId = 1, Operator = "9 Mobile Nigeria", OperatorCode = "ETN" },
                new CountryDetail { CountryId = 1, Operator = "Globacom Nigeria", OperatorCode = "GLO NG" },
                new CountryDetail { CountryId = 2, Operator = "Vodafone Ghana", OperatorCode = "Vodafone GH" },
                new CountryDetail { CountryId = 2, Operator = "MTN Ghana", OperatorCode = "MTN Ghana" },
                new CountryDetail { CountryId = 2, Operator = "Tigo Ghana", OperatorCode = "Tigo Ghana" },
                new CountryDetail { CountryId = 3, Operator = "MTN Benin", OperatorCode = "MTN Benin" },
                new CountryDetail { CountryId = 3, Operator = "Moov Benin", OperatorCode = "Moov Benin" },
                new CountryDetail { CountryId = 4, Operator = "MTN Côte d'Ivoire", OperatorCode = "MTN CIV" },
            };

            context.CountryDetails.AddRange(countryDetails);

            context.SaveChanges();
        }
    }

}
