using System;
using unirest_net.http;
using System.Xml;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace CurrencyConvert
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var exchangeRatesApi = RestService.For<ExchangeRateService>("https://openexchangerates.org/api");
            var service = await exchangeRatesApi.getRatesAsync();

            Console.Write("israel  " + service.Rates["ILS"]);
            
        }
    }
}
