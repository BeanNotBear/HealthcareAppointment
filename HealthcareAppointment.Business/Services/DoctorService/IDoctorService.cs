using HealthcareAppointment.Data.Dtos;
using HealthcareAppointment.Data.Dtos.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareAppointment.Business.Services.DoctorService
{
	public interface IDoctorService
	{
		public Task<PaginationList<DoctorDto>> GetItems(DoctorParameter parameter);
		public Task<DoctorDto> GetById(Guid id);
		public Task<DoctorDto> Create(AddDoctorRequestDto addDoctorRequestDto);
		public Task<DoctorDto> Update(Guid id, UpdateDoctorRequestDto updateDoctorRequestDto);
		public Task<bool> Delete(Guid id);
	}
}
