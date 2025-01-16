using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr.BL.DTOs.DepartmentDTOs;
using Pr.BL.DTOs.DoctorDTOs;
using Pr.Core.Models;

namespace Pr.BL.Services.Concretes
{
    public interface IDoctorService
    {
        Task<ICollection<Doctor>> GetAllAsync();
        Task<Doctor> GetByIdAsync(int id);
        Task<Doctor> CreateAsync(DoctorCreateDTO entity);
        Task<Doctor> Update(DoctorUpdateDTO entity);
        Task<Doctor> DeleteAsync(int id);
    }
}
