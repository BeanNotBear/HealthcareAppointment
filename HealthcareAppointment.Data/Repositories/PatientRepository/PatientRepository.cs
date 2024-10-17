using HealthcareAppointment.Data.Data;
using HealthcareAppointment.Data.Repositories.BaseRepository;
using HealthcareAppointment.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareAppointment.Data.Repositories.PatientRepository
{
	public class PatientRepository : BaseRepository<User, Guid>, IPatientRepository
	{
		public PatientRepository(HealthcareAppointmentDbContext context) : base(context)
		{
		}
	}
}
