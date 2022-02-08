using System.Collections.Generic;
using System.Threading.Tasks;
using CurrencyRates.IServices;
using CurrencyRates.Models;
using Microsoft.AspNetCore.Mvc;
namespace CurrencyRates.Controllers
{
    [ApiController]
    [Route("currency-rates")]
    public class CurrencyRateController : ControllerBase
    {
        private readonly ICurrencyRateService _currencyServices;

        public CurrencyRateController(ICurrencyRateService currencyServices)
        {
            _currencyServices = currencyServices;
        }

        /// <summary>
        /// Get currency Rate based on currency codes
        /// </summary>
        /// <param name="currencyCode">currency codes query parameter eg:'USD'</param>
        /// <returns>List of currency rates</returns>
        [HttpGet]
        [Route("{currencyCode}")]
        public async Task<List<CurrencyModel>> Get(string currencyCode = null)
        {
            return await _currencyServices.GetCurrencyRates(currencyCode);
        }
    }
}
