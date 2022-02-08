using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyRates.IProviders;
using CurrencyRates.IServices;
using CurrencyRates.Models;

namespace CurrencyRates.Services
{
    public class CurrencyCodeService : ICurrencyCodeService
    {
        private readonly ICurrencyXMLProvider _xmlService;
        public CurrencyCodeService(ICurrencyXMLProvider xmlService)
        {
            _xmlService = xmlService;
        }

        public async Task<List<CurrencyCodeModel>> GetCurrencyRates(string currencyCode)
        {
            var currencyListNodes = await _xmlService.GetCurrencyCodeList(currencyCode);
            return currencyListNodes.ToList();
        }
    }
}