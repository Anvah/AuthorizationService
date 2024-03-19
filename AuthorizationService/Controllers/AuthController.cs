using AuthorizationService.Models.RequestModels;
using AuthorizationService.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthorizationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("auth")]
        public IActionResult Authenticate([FromBody] AuthRequestModel request)
        {
            string token = _authService.Authenticate(request);
            if (token.IsNullOrEmpty())
                return Unauthorized();
            return Ok(new { Token = token });
        }
    }
}
