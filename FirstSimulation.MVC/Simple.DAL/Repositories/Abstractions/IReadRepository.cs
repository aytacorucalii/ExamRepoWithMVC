using Simple.Core.Models.Base;

namespace Simple.DAL.Repositories.Abstractions;

public interface IReadRepository<T> where T : BaseEntity, new()
{
    Task<ICollection<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<bool> IsExistsAsync(int id);

}
