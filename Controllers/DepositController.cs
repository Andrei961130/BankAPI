using Core.DTOs;
using Core.Services;
using Core.ExtensionMethods;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepositController : ControllerBase
    {
        private IDepositService DepositService { get; }

        public DepositController(IDepositService depositService)
        {
            DepositService = depositService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest paginationRequest)
        {
            var result = await DepositService.GetAll(paginationRequest);

            HttpContext.AddPaginationHeaders(paginationRequest, result.totalResults);

            if (result.deposits?.Any() != true) 
            {
                return NoContent();
            }

            return Ok(result.deposits);
        }
    }
}
