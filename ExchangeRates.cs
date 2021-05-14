using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CurrencyConvert
{
    public class ExchangeRates
    {
        public Rates rates;

        public class Rates
        {
            [JsonProperty("GBP")] public double GBP { get; set; }
            [JsonProperty("BOB")] public double BOB { get; set; }

            [JsonProperty("ILS")] public double ILS { get; set; }
        }

    }

}