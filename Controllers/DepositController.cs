using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepositController : ControllerBase
    {
        private IDepositService depositService { get; }

        public DepositController(IDepositService depositService)
        {
            this.depositService = depositService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await depositService.GetAll();

            if (result?.Any() != true) 
            {
                return NoContent();
            }

            return Ok(result);
        }
    }
}
