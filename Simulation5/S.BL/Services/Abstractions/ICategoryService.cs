using S.BL.DTOs.AtractionDTOs;
using S.BL.DTOs.CategoryDTOs;
using S.Core.Models;

namespace S.BL.Services.Abstractions
{
    public interface ICategoryService
    {
        Task<ICollection<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> CreateAsync(CategoryCreateDTO entity);
        Task<Category> Update(int id,CategoryUpdateDTO entity);
        Task<Category> Delete(int id);
    }
}
