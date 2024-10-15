using HealthcareAppointment.Data.Dtos;

namespace HealthcareAppointment.Business.Services.BaseService
{
	public interface IBaseService<TModel, TDto, TAddDto, TUpdateDto, TId>
		where TModel : class
		where TDto : class
		where TAddDto : class
		where TUpdateDto : class
	{
		public Task<PaginationList<TDto>> GetItems();
		public Task<TDto> GetById(TId id);
		public Task<TDto> Create(TAddDto addRequest);
		public Task<TDto> Update(TId id, TUpdateDto updateRequest);
		public Task<bool> Delete(TId id);
	}
}
