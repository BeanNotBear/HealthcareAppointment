using AutoMapper;
using HealthcareAppointment.Data.Dtos;
using HealthcareAppointment.Data.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareAppointment.Business.Services.BaseService
{
	public class BaseService<TModel, TDto, TAddDto, TUpdateDto, TId> : IBaseService<TModel, TDto, TAddDto, TUpdateDto, TId>
		where TModel : class
		where TDto : class
		where TAddDto : class
		where TUpdateDto : class
	{
		private readonly IBaseRepository<TModel, TId> baseRepository;
		private readonly IMapper mapper;

		public BaseService(IBaseRepository<TModel, TId> baseRepository, IMapper mapper)
		{
			this.baseRepository = baseRepository;
			this.mapper = mapper;
		}

		public async Task<TDto> Create(TAddDto addRequest)
		{
			var entity = mapper.Map<TModel>(addRequest);
			var createdEntity = await baseRepository.Add(entity);
			var entityDto = mapper.Map<TDto>(createdEntity);
			return entityDto;
		}

		public Task<bool> Delete(TId id)
		{
			throw new NotImplementedException();
		}

		public Task<TDto> GetById(TId id)
		{
			throw new NotImplementedException();
		}

		public Task<PaginationList<TDto>> GetItems()
		{
			throw new NotImplementedException();
		}

		public Task<TDto> Update(TId id, TUpdateDto updateRequest)
		{
			throw new NotImplementedException();
		}
	}
}
