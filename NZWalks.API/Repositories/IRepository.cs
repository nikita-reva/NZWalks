namespace NZWalks.API.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(string? filterOn = null, string? filterQuery = null,
            string? sortBy = null, bool isAscending = true,
            int pageNumber = 1, int pageSize = 1000);

        Task<T?> GetByIdAsync(Guid id);

        Task<T> CreateAsync(T record);

        Task<T?> UpdateAsync(Guid id, T record);

        Task<T?> DeleteAsync(Guid id);
    }
}
