using Core.Services;
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
        public async Task<IActionResult> GetAll()
        {
            var result = await WithdrawalService.GetAll();

            if (result?.Any() != true)
            {
                return NoContent();
            }

            return Ok(result);
        }
    }
}
