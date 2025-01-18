using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using S.BL.DTOs.CategoryDTOs;
using S.BL.DTOs.CategoryDTOs;
using S.BL.Services.Abstractions;
using S.Core.Models;
using S.DAL.Repositories.Abstractions;

namespace S.BL.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CategoryService(ICategoryRepository repository, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _repository = repository;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<ICollection<Category>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
        public async Task<Category> CreateAsync(CategoryCreateDTO entityDTO)
        {
            Category Category = _mapper.Map<Category>(entityDTO);
            var created = await _repository.CreateAsync(Category);
            await _repository.SaveChangesAsync();
            return created;

        }

        public async Task<Category> Delete(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            await _repository.Delete(entity);
            await _repository.SaveChangesAsync();
            return entity;
        }


        public async Task<Category> Update(int id, CategoryUpdateDTO entityDTO)
        {
            Category Category = _mapper.Map<Category>(entityDTO);
            var entity = await _repository.GetByIdAsync(id);
            await _repository.Update(Category);
            await _repository.SaveChangesAsync();
            return Category;
        }
    }
}
