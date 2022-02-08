using System.Collections.Generic;
using System.Threading.Tasks;
using CurrencyRates.Models;

namespace CurrencyRates.IProviders
{
    public interface ICurrencyXMLProvider
    {
        public Task<IEnumerable<CurrencyModel>> GetCurrencyList(string currencyCode);
        public Task<IEnumerable<CurrencyCodeModel>> GetCurrencyCodeList(string currencyCode);
    }
}