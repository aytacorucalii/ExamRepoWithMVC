using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Plumberz.BL.DTOs.TechnicianDTOs;
using Plumberz.BL.Exceptions;
using Plumberz.BL.Services.Abstractions;
using Plumberz.Core.Models;
using Plumberz.DAL.Repositories.Abstractions;

namespace Plumberz.BL.Services.Concretes;

public class TechnicianService : ITechnicianService
{
    private readonly ITechnicianRepository _technicianRepository;
    private readonly IMapper _mapper;
  

    public TechnicianService(ITechnicianRepository technicianRepository, IMapper mapper)
    {
        _technicianRepository = technicianRepository;
        _mapper = mapper;
    }

    public async Task<Technician> CreateAsync(TechnicianDTO entityDTO)
    {
       Technician technician = _mapper.Map<Technician>(entityDTO);
        technician.CreatedDate = DateTime.Now;
        var entity = await _technicianRepository.CreateAsync(technician);
        await _technicianRepository.SaveChangesAsync();
       return entity;
    }

    public async Task<List<Technician>> GetAllAsync()
    {
       return await _technicianRepository.GetAll().ToListAsync();
    }

    public async Task<Technician> GetByIdAsync(int id)
    {
        if (!await _technicianRepository.IsExistsAsync(id))
        {
            throw new EntityNotFoundExcepion();
        }
        return await _technicianRepository.GetByIdAsync(id);
    }



    public async Task<bool> SoftDelete(int id)
    {
       var entity = await _technicianRepository.GetByIdAsync(id);
        _technicianRepository.SoftDelete(entity);
        await _technicianRepository.SaveChangesAsync();
        return true;

    }

    public async Task<bool> Update(int id,TechnicianDTO entityDTO)
    {
        var entity = await _technicianRepository.GetByIdAsync(id);
        Technician technician = _mapper.Map<Technician>(entityDTO);
        technician.CreatedDate = DateTime.Now;
        technician.Id = id;
        _technicianRepository.Update(entity);
        await _technicianRepository.SaveChangesAsync();
        return true;
    }
}
