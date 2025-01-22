using AutoMapper;
using Exam.BL.DTOs;

using Exam.BL.Exceptions;
using Exam.BL.Services.Abstractions;
using Exam.BL.Utilities;
using Exam.Core.Models;
using Exam.DAL.Repository.Abstractions;

namespace Exam.BL.Services.Concretes;

public class PersonService : IPersonService
{
    readonly IRepository<Person> _repository;
    readonly IRepository<Car> _carRepository;
    readonly IMapper _mapper;
    public PersonService(IRepository<Person> repository, IMapper mapper, IRepository<Car> PersonRepository)
    {
        _repository = repository;
        _mapper = mapper;
        _carRepository = PersonRepository;
    }


    public async Task CreateAsync(PersonCreateDTO dto)
    {
        
        Person Person = _mapper.Map<Person>(dto);
  
        await _repository.CreateAsync(Person);

    }

    public async Task DeleteAsync(int id)
    {
        Person person = await GetByAsync(id);
        _repository.Delete(person);
  
    }

    public async Task<Person?> GetByAsync(int id) => await _repository.GeByAsync(id);


    public async Task<PersonUpdateDTO> GetByIdForUpdateAsync(int id) => _mapper.Map<PersonUpdateDTO>(await _repository.GetAllAsync());

    public async Task<Person> GetByIdWithChildAsync(int id) => _mapper.Map<Person>(await _repository.GeByAsync(id, "Cars")) ?? throw new BaseException();
    
    public async Task<ICollection<PersonListItemDTO>> GetPersonListItemAsync() => _mapper.Map<ICollection<PersonListItemDTO>>(await _repository.GetAllAsync());


    public async Task<ICollection<PersonViewItemDTO>> GetViewItemAsync() => _mapper.Map<ICollection<PersonViewItemDTO>>(await _repository.GetAllAsync("Cars"));


    public async Task<int> SaveChangesAsync() => await _repository.SaveChangesAsync();


    public async Task UpdateAsync(PersonUpdateDTO dto)
    {
      
        Person oldPerson = await _repository.GeByAsync(dto.Id);
        Person Person = _mapper.Map<Person>(dto);
        oldPerson.CreatedAt = Person.CreatedAt;

        _repository.Update(Person);
    }
}
