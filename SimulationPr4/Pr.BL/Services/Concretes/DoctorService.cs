using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Pr.BL.DTOs.DoctorDTOs;
using Pr.BL.Services.Abstractions;
using Pr.Core.Models;
using Pr.DAL.Repositories.Abstractions;

namespace Pr.BL.Services.Concretes
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DoctorService(IDoctorRepository repository, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _repository = repository;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<ICollection<Doctor>> GetAllAsync()
        {
           return await _repository.GetAllAsync();
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {
          var entity =  await _repository.GetByIdAsync(id);
            return entity;
        }
        public async Task<Doctor> CreateAsync(DoctorCreateDTO entityDTo)
        {
            Doctor created = _mapper.Map<Doctor>(entityDTo);
            created.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _repository.CreateAsync(created);
            await _repository.SaveChangesAsync();
            return created;
        }

        public async Task<Doctor> DeleteAsync(int id)
        {
           var entity = await _repository.GetByIdAsync(id);
            entity.DeleteDate = DateTime.UtcNow.AddHours(4);
            await _repository.DeleteAsync(entity);
            await _repository.SaveChangesAsync();
            return entity;
        }


        public async Task<Doctor> Update(DoctorUpdateDTO entityDTo)
        {
            Doctor created = _mapper.Map<Doctor>(entityDTo);
            await _repository.Update(created);
            await _repository.SaveChangesAsync();
            return created;
        }
    }
}
