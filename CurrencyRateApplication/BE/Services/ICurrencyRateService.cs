using System.Collections.Generic;
using System.Threading.Tasks;
using CurrencyRates.Models;

namespace CurrencyRates.IServices
{
    public interface ICurrencyRateService
    {
        public Task<List<CurrencyModel>> GetCurrencyRates(string currencyCode);
    }
}