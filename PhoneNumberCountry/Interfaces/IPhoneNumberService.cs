using PhoneNumberCountry.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberCountry.Interfaces
{
    public interface IPhoneNumberService
    {
        Task<PhoneNumberInfoViewModel> Get(string phoneNumber);
    }
}
