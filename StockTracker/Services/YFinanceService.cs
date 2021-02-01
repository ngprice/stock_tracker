using Newtonsoft.Json;
using StockTracker.Models.YFinance;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StockTracker.Services
{
    public class YFinanceService : IStockService
    {
        private const string baseUrl = @"https://query1.finance.yahoo.com/v7/finance/options/{0}";

        private readonly IHttpClientFactory _clientFactory;

        public YFinanceService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<Root> GetSymbolAsync(string symbol)
        {
            var path = String.Format(baseUrl, symbol);
            var request = new HttpRequestMessage(HttpMethod.Get, path);

            var response = await _clientFactory.CreateClient().SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());
                return result;
            }
            else
            {
                throw new HttpRequestException("Error calling Yahoo Finance API: " + response.ReasonPhrase, null, response.StatusCode);
            }
        }
    }
}
