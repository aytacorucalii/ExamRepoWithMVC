using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Hosting;
using S.BL.DTOs.AtractionDTOs;
using S.BL.Services.Abstractions;
using S.Core.Models;
using S.DAL.Repositories.Abstractions;

namespace S.BL.Services.Concretes
{
    public class AtractionService : IAtractionService
    {
        private readonly IAtractionRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AtractionService(IAtractionRepository repository, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _repository = repository;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<ICollection<AtractionUpdateDTO>> GetAllAsync()
        {
           ICollection<Atraction> atractions = await _repository.GetAllAsync();
            return _mapper.Map<ICollection< AtractionUpdateDTO>>(atractions);
        }

        public async Task<Atraction> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
        public async Task<Atraction> CreateAsync(AtractionCreateDTO entityDTO)
        {
            Atraction atraction = _mapper.Map<Atraction>(entityDTO);
            var created = await _repository.CreateAsync(atraction);
            await _repository.SaveChangesAsync();
            return created;

        }

        public async Task<Atraction> Delete(int id)
        {
           var entity = await _repository.GetByIdAsync(id);
            await _repository.Delete(entity);
            await _repository.SaveChangesAsync();
            return entity;
        }


        public async Task<Atraction> Update(int id,AtractionUpdateDTO entityDTO)
        {
            Atraction atraction = _mapper.Map<Atraction>(entityDTO);
            var entity = await _repository.GetByIdAsync(id);
            await _repository.Update(atraction);
            await _repository.SaveChangesAsync();
            return atraction;
        }
    }
}
