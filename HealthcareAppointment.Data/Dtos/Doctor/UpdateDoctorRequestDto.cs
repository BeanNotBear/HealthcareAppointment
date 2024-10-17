using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareAppointment.Data.Dtos.Doctor
{
	public class UpdateDoctorRequestDto
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Password { get; set; }
		public string Specialization { get; set; }
	}
}
