using FSD.Domain.Interfaces;
using FSD.Infrastructure.Context.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FSD.Application.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAuthService authService;

        public AdminController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            await authService.Register(model);
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });

        }

        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {
            await authService.RegisterAdmin(model);
            return Ok(new Response { Status = "Success", Message = "User Admin created successfully!" });
        }
    }
}
