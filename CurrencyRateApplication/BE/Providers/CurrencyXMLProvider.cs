using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
using CurrencyRates.IProviders;
using CurrencyRates.Models;
using System;

namespace CurrencyRates.Providers
{
    public class CurrencyXMLProvider : ICurrencyXMLProvider
    {
        private readonly Func<string, string> xmlPath = (string x) => $"http://www.floatrates.com/daily/{x}.xml";

        private CurrencyModel ToCurrencyModel(XElement x)
        {
            return new CurrencyModel()
            {
                CurrencyCode = x.Element("targetCurrency").Value,
                CurrencyName = x.Element("targetName").Value,
                ExchangeRate = double.Parse(x.Element("exchangeRate").Value),
                InverseRate = double.Parse(x.Element("inverseRate").Value)
            };
        }
        private CurrencyCodeModel ToCurrencyCodeModel(XElement x)
        {
            return new CurrencyCodeModel()
            {
                Code = x.Element("targetCurrency").Value,
                Name = x.Element("targetName").Value,
            };
        }
        private async Task<IEnumerable<XElement>> GetCurrencyElementsList(string currencyCode)
        {
            return await Task.Run(() =>
            {
                var path = xmlPath(currencyCode.ToLower());
                try
                {
                    var document = XDocument.Load(path);
                    return document.Descendants("item");
                }
                catch (System.Exception)
                {
                    throw;
                }
            });
        }
        public async Task<IEnumerable<CurrencyModel>> GetCurrencyList(string currencyCode)
        {
            var currencyItems = await GetCurrencyElementsList(currencyCode);
            return currencyItems.Select(x => ToCurrencyModel(x));
        }
        public async Task<IEnumerable<CurrencyCodeModel>> GetCurrencyCodeList(string currencyCode)
        {
            var currencyItems = await GetCurrencyElementsList(currencyCode);
            return currencyItems.Select(x => ToCurrencyCodeModel(x));
        }
    }
}