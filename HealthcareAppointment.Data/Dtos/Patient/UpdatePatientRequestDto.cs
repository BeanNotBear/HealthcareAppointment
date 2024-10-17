using HealthcareAppointment.Models.Enum;

namespace HealthcareAppointment.Data.Dtos.Patient
{
	public class UpdatePatientRequestDto
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Password { get; set; }
		public string Specialization { get; set; }
	}
}
