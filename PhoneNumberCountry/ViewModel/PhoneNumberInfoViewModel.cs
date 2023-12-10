using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberCountry.ViewModel
{
    public class PhoneNumberInfoViewModel
    {
        public string number { get; set; }
        public CountryViewModel country { get; set; }
    }

    public class CountryViewModel
    {
        public string countryCode { get; set; }
        public string name { get; set; }
        public string countryIso { get; set; }
        public List<CountryDetailViewModel> countryDetails { get; set; }
    }

    public class CountryDetailViewModel
    {
        public string Operator { get; set; }
        public string operatorCode { get; set; }
    }

}
