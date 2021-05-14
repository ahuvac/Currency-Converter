using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
namespace CurrencyConvert
{
    public class ExchangeRates
    {
        [JsonPropertyName("rates")] 
        public Dictionary<string, double> Rates { get; set; }
    }
    public partial class Rates
    {
        public static Rates FromJson(string json) => JsonConvert.DeserializeObject<Rates>(json, Converter.Settings);
    }
    public static class Serialize
    {
        public static string ToJson(this Rates self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

}