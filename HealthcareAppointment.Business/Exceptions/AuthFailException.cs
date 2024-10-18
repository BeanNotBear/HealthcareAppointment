using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareAppointment.Business.Exceptions
{
	public class AuthFailException : Exception
	{
		public AuthFailException(string? message) : base(message)
		{
		}
	}
}
