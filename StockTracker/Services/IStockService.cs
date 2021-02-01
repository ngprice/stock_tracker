using StockTracker.Models.YFinance;
using System.Threading.Tasks;

namespace StockTracker.Services
{
    public interface IStockService
    {
        public Task<Root> GetSymbolAsync(string symbol);
    }
}
