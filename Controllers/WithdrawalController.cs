using Core.DTOs;
using Core.Services;
using Core.ExtensionMethods;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WithdrawalController : ControllerBase
    {
        private IWithdrawalService WithdrawalService { get; }

        public WithdrawalController(IWithdrawalService withdrawalService)
        {
            WithdrawalService = withdrawalService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest paginationRequest)
        {
            var result = await WithdrawalService.GetAll(paginationRequest);

            HttpContext.AddPaginationHeaders(paginationRequest, result.totalResults);

            if (result.withdrawals?.Any() != true)
            {
                return NoContent();
            }

            return Ok(result.withdrawals);
        }
    }
}
