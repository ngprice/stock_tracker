using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StockTracker.Models.YFinance;
using StockTracker.Services;
using System.Threading.Tasks;

namespace StockTracker.Controllers
{
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _service;
        private readonly ILogger<StockController> _logger;

        public StockController(IStockService service, ILogger<StockController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("[controller]/{symbol}")]
        public async Task<ActionResult<Root>> Get(string symbol)
        {
            var result = await _service.GetSymbolAsync(symbol);
            return Ok(result);
        }
    }
}
