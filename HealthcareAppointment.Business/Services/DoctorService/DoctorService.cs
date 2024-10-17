using AutoMapper;
using HealthcareAppointment.Data.Dtos;
using HealthcareAppointment.Data.Dtos.Doctor;
using HealthcareAppointment.Data.Dtos.Patient;
using HealthcareAppointment.Data.Repositories.DoctorRepository;
using HealthcareAppointment.Data.Specifications;
using HealthcareAppointment.Models.Entities;
using HealthcareAppointment.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareAppointment.Business.Services.DoctorService
{
	public class DoctorService : IDoctorService
	{
		private readonly IDoctorRepository doctorRepository;
		private readonly IMapper mapper;

		public DoctorService(IDoctorRepository doctorRepository, IMapper mapper)
		{
			this.doctorRepository = doctorRepository;
			this.mapper = mapper;
		}

		public async Task<DoctorDto> Create(AddDoctorRequestDto addDoctorRequestDto)
		{
			var doctorDomain = mapper.Map<User>(addDoctorRequestDto);
			doctorDomain.Role = Role.Doctor;
			var createdDoctor = await doctorRepository.Add(doctorDomain);
			var doctorDto = mapper.Map<DoctorDto>(createdDoctor);
			return doctorDto;
		}

		public async Task<bool> Delete(Guid id)
		{
			var isDeleted = await doctorRepository.Delete(id);
			return isDeleted;
		}

		public async Task<DoctorDto> GetById(Guid id)
		{
			var doctorDomain = await doctorRepository.GetById(id);
			var doctorDto = mapper.Map<DoctorDto>(doctorDomain);
			return doctorDto;
		}

		public async Task<PaginationList<DoctorDto>> GetItems(DoctorParameter doctorParameter)
		{
			var spec = new BaseSpecification<User>(x =>
				x.Role == Role.Doctor &&
				(string.IsNullOrWhiteSpace(doctorParameter.Search) || x.Name.Contains(doctorParameter.Search) || x.Email.Contains(doctorParameter.Search))
			);

			if (!doctorParameter.IsDescending)
			{
				spec.AddOrderBy(x => x.Name);
			}
			else
			{
				spec.AddDescending(x => x.Name);
			}

			var take = doctorParameter.PageSize;
			var skip = (doctorParameter.PageNumber - 1) * take;

			spec.EnablePaging(take, skip);
			var doctorDomains = await doctorRepository.GetItems(spec);
			var doctorDtos = mapper.Map<PaginationList<DoctorDto>>(doctorDomains);
			return doctorDtos;
		}

		public async Task<DoctorDto> Update(Guid id, UpdateDoctorRequestDto updateDoctorRequestDto)
		{
			var doctorDomain = mapper.Map<User>(updateDoctorRequestDto);
			doctorDomain.Id = id;
			var updatedDoctor = await doctorRepository.Update(id, doctorDomain);
			var doctorDto = mapper.Map<DoctorDto>(updatedDoctor);
			return doctorDto;
		}
	}
}
