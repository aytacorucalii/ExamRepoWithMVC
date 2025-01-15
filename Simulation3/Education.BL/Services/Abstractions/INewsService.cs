using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education.BL.DTOs.NewsDTOs;
using Education.Core.Models;

namespace Education.BL.Services.Abstractions;

public interface INewsService
{
    Task<ICollection<News>> GetAllAsync();
    Task<News> GetByIdAsync(int id);
    Task<News> CreateAsync(NewsCreateDTO entityDTO);
    Task<bool> Update(int id,NewsUpdateDTO entityDTO);
    Task<bool> DeleteAsync(int id);
}
