using Test.Core.Entities.Base;

namespace Test.DAL.Repositories.Abstractions;

public interface IReadRepository<T>:IRepository<T> where T : BaseEntity, new()
{
}
