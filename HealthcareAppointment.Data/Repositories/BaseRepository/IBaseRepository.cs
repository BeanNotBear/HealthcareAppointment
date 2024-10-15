using HealthcareAppointment.Data.Dtos;
using HealthcareAppointment.Data.Specifications.Basespecification;

namespace HealthcareAppointment.Data.Repositories.BaseRepository
{
	public interface IBaseRepository<T, P> where T : class
	{
		Task<PaginationList<T>> GetItems(IBaseSpecification<T> specification);
		Task<T?> GetById(IBaseSpecification<T> specification);
		Task<T> Add(T item);
		Task<T?> Update(P id, T item);
		Task<bool> Delete(P id);
	}
}
