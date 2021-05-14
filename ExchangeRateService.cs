using System.Threading.Tasks;
using Refit;

namespace CurrencyConvert
{
    public interface ExchangeRateService
    {
        [Get("/latest.json?app_id=5891c536b91c48fcb68983823cf0166b")]
        Task<ExchangeRates> getRatesAsync();
    }
}