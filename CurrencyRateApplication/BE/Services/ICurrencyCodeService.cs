using System.Collections.Generic;
using System.Threading.Tasks;
using CurrencyRates.Models;

namespace CurrencyRates.IServices
{
    public interface ICurrencyCodeService
    {
        public Task<List<CurrencyCodeModel>> GetCurrencyRates(string currencyCode);
    }
}