using AutoMapper;
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

        public DoctorService(IDoctorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<ICollection<Doctor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Doctor> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Doctor> CreateAsync(DoctorCreateDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task Update(DoctorUpdateDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
