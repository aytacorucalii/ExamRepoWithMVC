using Simple.Core.Models.Base;

namespace Simple.DAL.Repositories.Abstractions;

public interface IWriteRepository<T> where T : BaseEntity, new()
{
    Task<T> CreateAsync(T entity);
    void Update(T entity);
    void SoftDelete(T entity);
    Task<int> SaveChangesAsync();
}
