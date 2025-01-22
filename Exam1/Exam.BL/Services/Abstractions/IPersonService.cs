using Exam.BL.DTOs;
using Exam.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BL.Services.Abstractions
{
    public interface IPersonService
    {
        Task<ICollection<PersonViewItemDTO>> GetViewItemAsync();
        Task<ICollection<PersonListItemDTO>> GetPersonListItemAsync();
        Task<Person> GetByIdWithChildAsync(int id);
        Task<Person?> GetByAsync(int id);
        Task<PersonUpdateDTO> GetByIdForUpdateAsync( int id);
        Task CreateAsync( PersonCreateDTO dto);
        Task UpdateAsync(PersonUpdateDTO dto);
        Task DeleteAsync(int id);
        Task<int> SaveChangesAsync();
    }
}
