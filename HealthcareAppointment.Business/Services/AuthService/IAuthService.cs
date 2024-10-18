using HealthcareAppointment.Data.Dtos.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareAppointment.Business.Services.AuthService
{
	public interface IAuthService
	{
		Task<string> Authenticate(LoginRequestDto loginRequestDto);
	}
}
