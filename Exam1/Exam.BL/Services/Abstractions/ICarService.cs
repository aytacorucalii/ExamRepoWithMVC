using Exam.BL.DTOs;
using Exam.BL.DTOs;
using Exam.Core.Models;

namespace Exam.BL.Services.Abstractions
{
    public interface ICarService
    {
        Task<ICollection<CarViewItemDTO>> GetViewItemAsync();
        Task<ICollection<CarListItemDTO>> GetPersonListItemAsync();
        Task<Car?> GetByAsync(int id);
        Task<CarUpdateDTO> GetByIdForUpdateAsync(int id);
        Task CreateAsync(CarCreateDTO dto);
        Task UpdateAsync(CarUpdateDTO dto);
        Task DeleteAsync(int id);
        Task<int> SaveChangesAsync();
    }
}
