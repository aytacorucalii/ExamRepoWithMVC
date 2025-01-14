

using Plumberz.BL.DTOs.TechnicianDTOs;
using Plumberz.Core.Models;

namespace Plumberz.BL.Services.Abstractions;

public interface ITechnicianService
{
    Task<List<Technician>> GetAllAsync();
    Task<Technician> GetByIdAsync(int id);
    Task<Technician> CreateAsync(TechnicianDTO entity);
    Task<bool> Update(int id,TechnicianDTO entity);
    Task<bool> SoftDelete(int id);

}
