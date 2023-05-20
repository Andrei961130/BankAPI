using Core.DTOs;
using Core.ExtensionMethods;
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
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest paginationRequest)
        {
            var result = await TradeOrderService.GetAll(paginationRequest);

            HttpContext.AddPaginationHeaders(paginationRequest, result.totalResults);

            if (result.tradeOrders?.Any() != true)
            {
                return NoContent();
            }

            return Ok(result.tradeOrders);
        }
    }
}
