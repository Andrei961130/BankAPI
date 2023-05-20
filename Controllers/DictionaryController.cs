using Core.DTOs;
using Infrastructure.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DictionaryController : ControllerBase
    {
        public DictionaryController()
        {
            
        }

        [HttpGet("headers")]
        public async Task<IActionResult> GetHeaders([FromQuery] string className)   
        {
            List<string> headerList = null;

            switch (className.ToLower())
            {
                case "deposit":
                    headerList = StringMethods.GetParameterNames<DepositDTOResponse>();
                    break;
                case "withdrawal":
                    headerList = StringMethods.GetParameterNames<WithdrawalDTOResponse>();
                    break;
                case "tradeorder":
                    headerList = StringMethods.GetParameterNames<TradeOrderDTOResponse>();
                    break;
                default:
                    break;
            }

            if(headerList?.Any() != true)
            {
                return NoContent();
            }

            return Ok(headerList);
        }
    }
}
