using HealthcareAppointment.Data.Dtos;
using HealthcareAppointment.Data.Specifications.Basespecification;

namespace HealthcareAppointment.Data.Repositories.BaseRepository
{
	public interface IBaseRepository<T, P> where T : class
	{
		PaginationList<T> GetItems(IBaseSpecification<T> specification);
		T GetById(P id);
		T Add(T item);
		T Update(P id, T item);
		T Delete(P id);
	}
}
