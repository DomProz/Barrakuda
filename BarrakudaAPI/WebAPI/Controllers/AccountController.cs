using Application.Interfaces;
using Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost("register")]
        public async Task<ActionResult> RegisterUser([FromBody]RegisterUserDto registerUserDto)
        {
            await _accountService.RegisterUserAsync(registerUserDto);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<ActionResult> LoginUser([FromBody]LoginDto loginDto)
        {
            string token = await _accountService.GenerateJwt(loginDto);
            return Ok(token);
        }
    }
}
