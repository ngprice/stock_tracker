using Newtonsoft.Json;
using System.Collections.Generic;

namespace StockTracker.Models.YFinance
{
    public class Result
    {
        [JsonProperty("underlyingSymbol")]
        public string UnderlyingSymbol { get; set; }

        [JsonProperty("expirationDates")]
        public List<int> ExpirationDates { get; set; }

        [JsonProperty("strikes")]
        public List<double> Strikes { get; set; }

        [JsonProperty("hasMiniOptions")]
        public bool HasMiniOptions { get; set; }

        [JsonProperty("quote")]
        public Quote Quote { get; set; }

        [JsonProperty("options")]
        public List<Option> Options { get; set; }
    }
}
