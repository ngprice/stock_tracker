using Newtonsoft.Json;

namespace StockTracker.Models.YFinance
{
    public class Quote
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("quoteType")]
        public string QuoteType { get; set; }

        [JsonProperty("quoteSourceName")]
        public string QuoteSourceName { get; set; }

        [JsonProperty("triggerable")]
        public bool Triggerable { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("longName")]
        public string LongName { get; set; }

        [JsonProperty("messageBoardId")]
        public string MessageBoardId { get; set; }

        [JsonProperty("exchangeTimezoneName")]
        public string ExchangeTimezoneName { get; set; }

        [JsonProperty("exchangeTimezoneShortName")]
        public string ExchangeTimezoneShortName { get; set; }

        [JsonProperty("gmtOffSetMilliseconds")]
        public int GmtOffSetMilliseconds { get; set; }

        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("esgPopulated")]
        public bool EsgPopulated { get; set; }

        [JsonProperty("sharesOutstanding")]
        public int SharesOutstanding { get; set; }

        [JsonProperty("bookValue")]
        public double BookValue { get; set; }

        [JsonProperty("fiftyDayAverage")]
        public double FiftyDayAverage { get; set; }

        [JsonProperty("fiftyDayAverageChange")]
        public double FiftyDayAverageChange { get; set; }

        [JsonProperty("fiftyDayAverageChangePercent")]
        public double FiftyDayAverageChangePercent { get; set; }

        [JsonProperty("twoHundredDayAverage")]
        public double TwoHundredDayAverage { get; set; }

        [JsonProperty("twoHundredDayAverageChange")]
        public double TwoHundredDayAverageChange { get; set; }

        [JsonProperty("twoHundredDayAverageChangePercent")]
        public double TwoHundredDayAverageChangePercent { get; set; }

        [JsonProperty("marketCap")]
        public long MarketCap { get; set; }

        [JsonProperty("forwardPE")]
        public double ForwardPE { get; set; }

        [JsonProperty("priceToBook")]
        public double PriceToBook { get; set; }

        [JsonProperty("sourceInterval")]
        public int SourceInterval { get; set; }

        [JsonProperty("exchangeDataDelayedBy")]
        public int ExchangeDataDelayedBy { get; set; }

        [JsonProperty("tradeable")]
        public bool Tradeable { get; set; }

        [JsonProperty("marketState")]
        public string MarketState { get; set; }

        [JsonProperty("postMarketChangePercent")]
        public double PostMarketChangePercent { get; set; }

        [JsonProperty("postMarketTime")]
        public int PostMarketTime { get; set; }

        [JsonProperty("postMarketPrice")]
        public double PostMarketPrice { get; set; }

        [JsonProperty("postMarketChange")]
        public double PostMarketChange { get; set; }

        [JsonProperty("regularMarketChange")]
        public double RegularMarketChange { get; set; }

        [JsonProperty("regularMarketChangePercent")]
        public double RegularMarketChangePercent { get; set; }

        [JsonProperty("regularMarketTime")]
        public int RegularMarketTime { get; set; }

        [JsonProperty("regularMarketPrice")]
        public double RegularMarketPrice { get; set; }

        [JsonProperty("regularMarketDayHigh")]
        public double RegularMarketDayHigh { get; set; }

        [JsonProperty("regularMarketDayRange")]
        public string RegularMarketDayRange { get; set; }

        [JsonProperty("regularMarketDayLow")]
        public double RegularMarketDayLow { get; set; }

        [JsonProperty("regularMarketVolume")]
        public int RegularMarketVolume { get; set; }

        [JsonProperty("regularMarketPreviousClose")]
        public double RegularMarketPreviousClose { get; set; }

        [JsonProperty("bid")]
        public double Bid { get; set; }

        [JsonProperty("ask")]
        public double Ask { get; set; }

        [JsonProperty("bidSize")]
        public int BidSize { get; set; }

        [JsonProperty("askSize")]
        public int AskSize { get; set; }

        [JsonProperty("fullExchangeName")]
        public string FullExchangeName { get; set; }

        [JsonProperty("financialCurrency")]
        public string FinancialCurrency { get; set; }

        [JsonProperty("regularMarketOpen")]
        public double RegularMarketOpen { get; set; }

        [JsonProperty("averageDailyVolume3Month")]
        public int AverageDailyVolume3Month { get; set; }

        [JsonProperty("averageDailyVolume10Day")]
        public int AverageDailyVolume10Day { get; set; }

        [JsonProperty("fiftyTwoWeekLowChange")]
        public double FiftyTwoWeekLowChange { get; set; }

        [JsonProperty("fiftyTwoWeekLowChangePercent")]
        public double FiftyTwoWeekLowChangePercent { get; set; }

        [JsonProperty("fiftyTwoWeekRange")]
        public string FiftyTwoWeekRange { get; set; }

        [JsonProperty("fiftyTwoWeekHighChange")]
        public double FiftyTwoWeekHighChange { get; set; }

        [JsonProperty("fiftyTwoWeekHighChangePercent")]
        public double FiftyTwoWeekHighChangePercent { get; set; }

        [JsonProperty("fiftyTwoWeekLow")]
        public double FiftyTwoWeekLow { get; set; }

        [JsonProperty("fiftyTwoWeekHigh")]
        public double FiftyTwoWeekHigh { get; set; }

        [JsonProperty("dividendDate")]
        public int DividendDate { get; set; }

        [JsonProperty("earningsTimestamp")]
        public int EarningsTimestamp { get; set; }

        [JsonProperty("earningsTimestampStart")]
        public int EarningsTimestampStart { get; set; }

        [JsonProperty("earningsTimestampEnd")]
        public int EarningsTimestampEnd { get; set; }

        [JsonProperty("trailingAnnualDividendRate")]
        public double TrailingAnnualDividendRate { get; set; }

        [JsonProperty("trailingAnnualDividendYield")]
        public double TrailingAnnualDividendYield { get; set; }

        [JsonProperty("epsTrailingTwelveMonths")]
        public double EpsTrailingTwelveMonths { get; set; }

        [JsonProperty("epsForward")]
        public double EpsForward { get; set; }

        [JsonProperty("epsCurrentYear")]
        public double EpsCurrentYear { get; set; }

        [JsonProperty("priceEpsCurrentYear")]
        public double PriceEpsCurrentYear { get; set; }

        [JsonProperty("firstTradeDateMilliseconds")]
        public long FirstTradeDateMilliseconds { get; set; }

        [JsonProperty("priceHint")]
        public int PriceHint { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}
