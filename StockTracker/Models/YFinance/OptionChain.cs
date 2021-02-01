using Newtonsoft.Json;
using System.Collections.Generic;

namespace StockTracker.Models.YFinance
{
    public class OptionChain
    {
        [JsonProperty("result")]
        public List<Result> Result { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }
    }
}
