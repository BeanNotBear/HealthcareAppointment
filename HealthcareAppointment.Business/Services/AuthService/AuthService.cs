using HealthcareAppointment.Business.Exceptions;
using HealthcareAppointment.Business.Services.GenerateToken;
using HealthcareAppointment.Data.Dtos.Authentication;
using HealthcareAppointment.Data.Repositories.AuthRepository;
using HealthcareAppointment.Data.Repositories.DoctorRepository;
using HealthcareAppointment.Models.Enum;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareAppointment.Business.Services.AuthService
{
	public class AuthService : IAuthService
	{
		private readonly IAuthRepository authRepository;
		private readonly IConfiguration configuration;

		public AuthService(IAuthRepository authRepository, IConfiguration configuration)
		{
			this.authRepository = authRepository;
			this.configuration = configuration;
		}

		public async Task<string> Authenticate(LoginRequestDto loginRequestDto)
		{
			var user = await authRepository.Authenticate(loginRequestDto.Email, loginRequestDto.Password);
			if (user == null)
			{
				throw new AuthFailException("Email or Password is incorrect!");
			}
			var authClaims = new List<Claim>
			{
				new Claim(ClaimTypes.Name, user.Email),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new Claim(ClaimTypes.Role, user.Role.ToString()),
			};

			var token = authClaims.GenerateToken(configuration);
			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}
