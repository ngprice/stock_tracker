using Newtonsoft.Json;
using System.Collections.Generic;

namespace StockTracker.Models.YFinance
{
    public class Option
    {
        [JsonProperty("expirationDate")]
        public int ExpirationDate { get; set; }

        [JsonProperty("hasMiniOptions")]
        public bool HasMiniOptions { get; set; }

        [JsonProperty("calls")]
        public List<Call> Calls { get; set; }

        [JsonProperty("puts")]
        public List<Put> Puts { get; set; }
    }
}
