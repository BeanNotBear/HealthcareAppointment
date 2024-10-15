namespace HealthcareAppointment.Data.Dtos
{
	public class PaginationList<T>
	{
		public ICollection<T> Items { get; }
		public int PageNumber { get; }
		public int PageSize { get; }
		public int TotalPage { get; }
		public bool IsHasNextPage => PageNumber < TotalPage;

		public bool IsHasPreviousPage => PageNumber > 1;

		public PaginationList(ICollection<T> items, int pageNumber, int pageSize, int totalPage)
		{
			Items = items;
			PageNumber = pageNumber;
			PageSize = pageSize;
			TotalPage = totalPage;
		}
	}
}
