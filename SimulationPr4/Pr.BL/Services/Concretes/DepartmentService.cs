using Pr.BL.DTOs.DepartmentDTOs;
using Pr.BL.Services.Abstractions;
using Pr.Core.Models;

namespace Pr.BL.Services.Concretes
{
    public class DepartmentService : IDepartmentService
    {
        public Task<Department> CreateAsync(DepartmentCreateDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Department>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(DepartmentUpdateDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
