using Pr.BL.DTOs.DepartmentDTOs;
using Pr.Core.Models;

namespace Pr.BL.Services.Abstractions
{
    public interface IDepartmentService
    {
        Task<ICollection<Department>> GetAllAsync();
        Task<Department> GetByIdAsync(int id);
        Task<Department> CreateAsync(DepartmentCreateDTO entity);
        Task<Department> Update(DepartmentUpdateDTO entity);
        Task<Department> DeleteAsync(int id);
     
    }
}
