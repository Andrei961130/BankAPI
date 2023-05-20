﻿using Core.Services;
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
        public async Task<IActionResult> GetAll()
        {
            var result = await DepositService.GetAll();

            if (result?.Any() != true) 
            {
                return NoContent();
            }

            return Ok(result);
        }
    }
}
