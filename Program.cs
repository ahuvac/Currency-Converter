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
            // HttpResponse<ExchangeRates> response = Unirest
            //     .get("https://openexchangerates.org/api/latest.json?app_id=5891c536b91c48fcb68983823cf0166b")
            //     .header("Accept", "application/json")
            //    .asJson<ExchangeRates>();


            var exchangeRatesApi = RestService.For<ExchangeRateService>("https://openexchangerates.org/api");
            var service = await exchangeRatesApi.getRatesAsync();

            Console.Write("israel" + service.rates.BOB);
         
        }
    }
}
