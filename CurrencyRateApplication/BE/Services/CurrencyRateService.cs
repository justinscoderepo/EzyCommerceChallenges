using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyRates.IProviders;
using CurrencyRates.IServices;
using CurrencyRates.Models;

namespace CurrencyRates.Services
{
    public class CurrencyRateService : ICurrencyRateService
    {
        private readonly ICurrencyXMLProvider _xmlService;
        public CurrencyRateService(ICurrencyXMLProvider xmlService)
        {
            _xmlService = xmlService;
        }

        public async Task<List<CurrencyModel>> GetCurrencyRates(string currencyCode)
        {
            var currencyListNodes = await _xmlService.GetCurrencyList(currencyCode);
            return currencyListNodes.ToList();
        }
    }
}