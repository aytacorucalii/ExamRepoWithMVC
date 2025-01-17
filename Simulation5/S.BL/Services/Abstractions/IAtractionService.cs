using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S.BL.DTOs.AtractionDTOs;
using S.Core.Models;

namespace S.BL.Services.Abstractions
{
    public interface IAtractionService
    {
        Task<ICollection<AtractionUpdateDTO>> GetAllAsync();
        Task<Atraction> GetByIdAsync(int id);
        Task<Atraction> CreateAsync(AtractionCreateDTO entity);
        Task<Atraction> Update(int id, AtractionUpdateDTO entity);
        Task<Atraction> Delete(int id);
    }
}
