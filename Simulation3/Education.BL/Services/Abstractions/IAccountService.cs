using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education.BL.DTOs.AccountDTOs;

namespace Education.BL.Services.Abstractions
{
    public interface IAccountService
    {

        Task LoginAsync(LoginDTO user);
        Task RegisterAsync(RegisterDTO user);
        Task LogoutAsync();
    }
}
