using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhoneNumberCountry.Data;
using PhoneNumberCountry.Interfaces;
using System.Diagnostics;

namespace PhoneNumberCountryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhoneNumberController : ControllerBase
    {
        private readonly IPhoneNumberService phoneNumberService;

        public PhoneNumberController(IPhoneNumberService phoneNumberService)
        {
            this.phoneNumberService = phoneNumberService;
        }

        [HttpGet("{phoneNumber}")]
        public async Task<IActionResult> GetCountryDetails(string phoneNumber)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    return BadRequest("Invalid phone number");
                }
                var phoneNumberInfo = await phoneNumberService.Get(phoneNumber);

                if (phoneNumberInfo == null)
                {
                    return NotFound("Country not found");
                }

                return Ok(phoneNumberInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { description = ex.Message, code = "96" });
            }

        }
    }

}
