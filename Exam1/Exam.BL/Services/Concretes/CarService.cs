using AutoMapper;
using Exam.BL.DTOs;
using Exam.BL.DTOs;
using Exam.BL.Exceptions;
using Exam.BL.Services.Abstractions;
using Exam.BL.Utilities;
using Exam.Core.Models;
using Exam.DAL.Repository.Abstractions;

namespace Exam.BL.Services.Concretes;

public class CarService : ICarService
{
    readonly IRepository<Person> _repository;
    readonly IRepository<Car> _carRepository;
    readonly IMapper _mapper;
    public CarService(IRepository<Person> repository, IMapper mapper, IRepository<Car> carRepository)
    {
        _repository = repository;
        _mapper = mapper;
        _carRepository = carRepository;
    }

    public async Task CreateAsync(CarCreateDTO dto)
    {
        if (await _repository.GeByAsync(dto.PersonId) is null) throw new BaseException();
        Car car = _mapper.Map<Car>(dto);
        car.ImgUrl = await dto.Img.SaveAsync("Cars");
        await _carRepository.CreateAsync(car);

    }

    public async Task DeleteAsync(int id)
    {
       Car car = await GetByAsync(id);
        _carRepository.Delete(car);
        File.Delete(Path.Combine(Path.GetFullPath("wwwroot"), "Uploads", car.ImgUrl));
    }

    public async Task<Car?> GetByAsync(int id)=> await _carRepository.GeByAsync(id,"Person");
  

    public async Task<CarUpdateDTO> GetByIdForUpdateAsync(int id)=> _mapper.Map<CarUpdateDTO>(await _carRepository.GetAllAsync("Person"));




    public async Task<ICollection<CarListItemDTO>> GetPersonListItemAsync() => _mapper.Map <ICollection<CarListItemDTO>>(await _carRepository.GetAllAsync("Person"));


    public async Task<ICollection<CarViewItemDTO>> GetViewItemAsync() => _mapper.Map<ICollection<CarViewItemDTO>>(await _carRepository.GetAllAsync("Person"));
    

    public async Task<int> SaveChangesAsync()=>await _carRepository.SaveChangesAsync();
   

    public async Task UpdateAsync(CarUpdateDTO dto)
    {
        if (await _repository.GeByAsync(dto.Personİd) is null) throw new BaseException();
        Car oldcar = await _carRepository.GeByAsync(dto.Id);
        Car car = _mapper.Map<Car>(dto);
        oldcar.CreatedAt = car.CreatedAt;
        car.ImgUrl = dto.ImgUrl is not null ? await dto.Img.SaveAsync("Cars") : oldcar.ImgUrl;
         _carRepository.Update(car);
    }
}
