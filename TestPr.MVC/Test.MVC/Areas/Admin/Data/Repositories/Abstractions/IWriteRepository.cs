using Test.Core.Entities.Base;

namespace Test.DAL.Repositories.Abstractions;

public interface IWriteRepository<T>: IRepository<T> where T : BaseEntity, new()
{
}
