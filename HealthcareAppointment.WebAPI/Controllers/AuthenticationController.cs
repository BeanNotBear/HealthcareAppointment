using HealthcareAppointment.Business.Services.AuthService;
using HealthcareAppointment.Data.Dtos.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthcareAppointment.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthenticationController : ControllerBase
	{

		private readonly IAuthService authService;

		public AuthenticationController(IAuthService authService)
		{
			this.authService = authService;
		}

		[HttpPost]
		public async Task<IActionResult> Authenticate([FromBody] LoginRequestDto loginRequestDto)
		{
			var token = await authService.Authenticate(loginRequestDto);
			return Ok(token);
		}
	}
}
