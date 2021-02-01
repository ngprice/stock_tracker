using Newtonsoft.Json;

namespace StockTracker.Models.YFinance
{
    public class Root
    {
        [JsonProperty("optionChain")]
        public OptionChain OptionChain { get; set; }
    }
}
