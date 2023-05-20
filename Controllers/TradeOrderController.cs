using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TradeOrderController : ControllerBase
    {
        private ITradeOrderService TradeOrderService { get; }

        public TradeOrderController(ITradeOrderService tradeOrderService)
        {
            TradeOrderService = tradeOrderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await TradeOrderService.GetAll();

            if (result?.Any() != true)
            {
                return NoContent();
            }

            return Ok(result);
        }
    }
}
