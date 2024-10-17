using HealthcareAppointment.Data.Repositories.BaseRepository;
using HealthcareAppointment.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareAppointment.Data.Repositories.DoctorRepository
{
	public interface IDoctorRepository : IBaseRepository<User, Guid>
	{
	}
}
