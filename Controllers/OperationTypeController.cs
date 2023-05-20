using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperationTypeController : ControllerBase
    {
        private IOperationTypeService OperationTypeService { get; }

        public OperationTypeController(IOperationTypeService operationTypeService)
        {
            OperationTypeService = operationTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await OperationTypeService.GetAll();

            if (result?.Any() != true)
            {
                return NoContent();
            }

            return Ok(result);
        }
    }
}
