using Pr.BL.DTOs.DepartmentDTOs;
using Pr.Core.Models;

namespace Pr.BL.Services.Abstractions
{
    public interface IDepartmentService
    {
        Task<ICollection<Department>> GetAllAsync();
        Task<Department> GetByIdAsync(int id);
        Task<Department> CreateAsync(DepartmentCreateDTO entity);
        Task Update(DepartmentUpdateDTO entity);
        Task DeleteAsync(int id);
     
    }
}
