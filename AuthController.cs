using Asp.Versioning;
using Banking_Management_System.DTOS;
using Banking_Management_System.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking_Management_System.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("3.0")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _ser;
        public AuthController(IUserService ser)
        {
            _ser = ser;
        }
        [HttpPost("register")]
        public IActionResult registor(RegisterDto dto)
        {
            var r= _ser.Register(dto);
            return Ok (r);
        }

        [HttpPost("login")]
        public IActionResult login(LoginDto dto)
        {
            var r=_ser.Login(dto);
            return Ok(r);
        }
    }
}
