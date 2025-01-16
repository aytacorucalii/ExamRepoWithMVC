using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Pr.BL.DTOs.DepartmentDTOs;
using Pr.BL.DTOs.DepartmentDTOs;
using Pr.BL.Services.Abstractions;
using Pr.Core.Models;
using Pr.DAL.Repositories.Abstractions;

namespace Pr.BL.Services.Concretes
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DepartmentService(IDepartmentRepository repository, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _repository = repository;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<ICollection<Department>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Department> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity;
        }
        public async Task<Department> CreateAsync(DepartmentCreateDTO entityDTo)
        {
            Department created = _mapper.Map<Department>(entityDTo);
            created.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _repository.CreateAsync(created);
            await _repository.SaveChangesAsync();
            return created;
        }

        public async Task<Department> DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            entity.DeleteDate = DateTime.UtcNow.AddHours(4);
            await _repository.DeleteAsync(entity);
            await _repository.SaveChangesAsync();
            return entity;
        }


        public async Task<Department> Update(DepartmentUpdateDTO entityDTo)
        {
            Department created = _mapper.Map<Department>(entityDTo);
            await _repository.Update(created);
            await _repository.SaveChangesAsync();
            return created;
        }
    }
}
