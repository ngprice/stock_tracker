using Newtonsoft.Json;

namespace StockTracker.Models.YFinance
{
    public class Put
    {
        [JsonProperty("contractSymbol")]
        public string ContractSymbol { get; set; }

        [JsonProperty("strike")]
        public double Strike { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("lastPrice")]
        public double LastPrice { get; set; }

        [JsonProperty("change")]
        public double Change { get; set; }

        [JsonProperty("percentChange")]
        public double PercentChange { get; set; }

        [JsonProperty("volume")]
        public int Volume { get; set; }

        [JsonProperty("openInterest")]
        public int OpenInterest { get; set; }

        [JsonProperty("bid")]
        public double Bid { get; set; }

        [JsonProperty("ask")]
        public double Ask { get; set; }

        [JsonProperty("contractSize")]
        public string ContractSize { get; set; }

        [JsonProperty("expiration")]
        public int Expiration { get; set; }

        [JsonProperty("lastTradeDate")]
        public int LastTradeDate { get; set; }

        [JsonProperty("impliedVolatility")]
        public double ImpliedVolatility { get; set; }

        [JsonProperty("inTheMoney")]
        public bool InTheMoney { get; set; }
    }
}
