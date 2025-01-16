using Pr.Core.Models;
using Pr.DAL.Contexts;
using Pr.DAL.Repositories.Abstractions;

namespace Pr.DAL.Repositories.Concretes
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
