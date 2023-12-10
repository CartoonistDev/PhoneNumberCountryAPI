using Microsoft.EntityFrameworkCore;
using PhoneNumberCountry.Data;
using PhoneNumberCountry.Interfaces;
using PhoneNumberCountry.ViewModel;

namespace PhoneNumberCountry.Services
{
    public class PhoneNumberService : IPhoneNumberService
    {
        private readonly PhoneNumberContext _context;

        public PhoneNumberService(PhoneNumberContext context)
        {
            _context = context;
        }

        public async Task<PhoneNumberInfoViewModel?> Get(string phoneNumber)
        {

            if (string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length < 3)
            {
                return null;
            }

            // Extract the country code from the phone number
            string countryCode = phoneNumber.Substring(0, 3);

            // Find the country by the country code
            var country = await _context.Countries
                .Include(c => c.CountryDetails)
                .FirstOrDefaultAsync(c => c.CountryCode == countryCode);

            if (country == null)
            {
                return null;
            }

            var result = new PhoneNumberInfoViewModel
            {
                number = phoneNumber,
                country = new CountryViewModel
                {
                    countryCode = country.CountryCode,
                    name = country.Name,
                    countryIso = country.CountryIso,
                    countryDetails = country.CountryDetails.Select(cd => new CountryDetailViewModel
                    {
                        Operator = cd.Operator,
                        operatorCode = cd.OperatorCode
                    }).ToList()
                }
            };

            return result;
        }
    }
}
