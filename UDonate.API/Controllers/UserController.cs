using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UDonate.API.Contracts.User;
using UDonate.Application.Interfaces.Services;

namespace UDonate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromForm]LoginUserRequest request)
        {
            var token = await _userService.Login(request.email, request.password);
            HttpContext.Response.Cookies.Append("nanana-cookie", token);
            return Ok(token);
        }
    }
}
