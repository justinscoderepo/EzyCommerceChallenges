using System.Collections.Generic;
using System.Threading.Tasks;
using CurrencyRates.IServices;
using CurrencyRates.Models;
using Microsoft.AspNetCore.Mvc;
namespace CurrencyRates.Controllers
{
    [ApiController]
    [Route("currency-codes")]
    public class CurrencyCodeController : ControllerBase
    {
        private readonly ICurrencyCodeService _currencyCodeServices;
        private readonly string CurrencyCode = "usd";
        public CurrencyCodeController(ICurrencyCodeService currencyCodeServices)
        {
            _currencyCodeServices = currencyCodeServices;
        }

        /// <summary>
        /// Get currency exchange rates based on currency codes
        /// </summary>
        /// <returns>List of currency code with its names</returns>
        [HttpGet]
        public async Task<List<CurrencyCodeModel>> Get()
        {
            return await _currencyCodeServices.GetCurrencyRates(CurrencyCode);
        }
    }
}