namespace CurrencyRates.Models
{
    public class CurrencyModel
    {
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public double ExchangeRate { get; set; }
        public double InverseRate { get; set; }
    }
}